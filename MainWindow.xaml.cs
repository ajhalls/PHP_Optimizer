using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Reflection;
using Devsense.PHP.Syntax;
using Devsense.PHP.Syntax.Ast;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using PCRE;
using Pchp.CodeAnalysis;

namespace PHP_Optimizer
{
    public class ShouldSerializeContractResolver : DefaultContractResolver
    {
        public static ShouldSerializeContractResolver Instance { get; } = new ShouldSerializeContractResolver();

        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            JsonProperty property = base.CreateProperty(member, memberSerialization);

            return property;
        }
    }

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DBStorage.SQLite.Query("namespaces", @"CREATE TABLE IF NOT EXISTS namespaces (
            id INTEGER PRIMARY KEY AUTOINCREMENT ,
              	name text NOT NULL,
              	filename text NOT NULL)");
            DBStorage.SQLite.Query("codeObjects", @"CREATE TABLE IF NOT EXISTS code_objects (
                                                            id INTEGER PRIMARY KEY AUTOINCREMENT,
              	                                                namespace text NOT NULL,
              	                                                scope text NOT NULL,
              	                                                name text NOT NULL,
              	                                                args text NOT NULL,
              	                                                body text NOT NULL,
              	                                                total_using text,
              	                                                using_list text,
              	                                                internal_function_list text,
              	                                                internal_function_count INTEGER(3),
              	                                                filename text)");
            // Specify the starting folder on the command line, or in
            // Visual Studio in the Project > Properties > Debug pane.
            TraverseTree(@"C:\BitBucket\ReminderDental_Website\l8auth\app\Http\Controllers");
        }

        public static void TraverseTree(string root)
        {
            // Data structure to hold names of subfolders to be
            // examined for files.
            Stack<string> dirs = new Stack<string>(20);

            if (!System.IO.Directory.Exists(root))
            {
                throw new ArgumentException();
            }
            dirs.Push(root);

            while (dirs.Count > 0)
            {
                string currentDir = dirs.Pop();
                string[] subDirs;
                try
                {
                    subDirs = System.IO.Directory.GetDirectories(currentDir);
                }
                // An UnauthorizedAccessException exception will be thrown if we do not have
                // discovery permission on a folder or file. It may or may not be acceptable
                // to ignore the exception and continue enumerating the remaining files and
                // folders. It is also possible (but unlikely) that a DirectoryNotFound exception
                // will be raised. This will happen if currentDir has been deleted by
                // another application or thread after our call to Directory.Exists. The
                // choice of which exceptions to catch depends entirely on the specific task
                // you are intending to perform and also on how much you know with certainty
                // about the systems on which this code will run.
                catch (UnauthorizedAccessException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                catch (System.IO.DirectoryNotFoundException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }

                string[] files = null;
                try
                {
                    files = System.IO.Directory.GetFiles(currentDir);
                }
                catch (UnauthorizedAccessException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                catch (System.IO.DirectoryNotFoundException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                // Perform the required action on each file here.
                // Modify this block to perform your required task.
                int counter = 0;
                foreach (string file in files)
                {
                    counter++;
                    try
                    {
                        // Perform whatever action is required in your scenario.
                        System.IO.FileInfo fi = new System.IO.FileInfo(file);
                        string contents = File.ReadAllText(file);

                        contents = StripComments(contents);

                        string pattern = @"namespace (.*);";
                        var NameSpace = PCRE.PcreRegex.Match(contents, pattern).ToArray();
                        //System.Data.DataTable results = DBStorage.SQLite.Query("namespaces", "SELECT id from namespaces where name='" + NameSpace[1] + "'");
                        //if (results != null && results.Rows.Count == 0)
                        //{
                        //    //DBStorage.SQLite.Query("namespaces", @"INSERT INTO namespaces VALUES(" + counter + ",'" + NameSpace[1] + "','" + fi.Name + "')");
                        //}

                        pattern = @"use (.*);";
                        PcreMatch[] Dependencies = PCRE.PcreRegex.Matches(contents, pattern).ToArray();
                        var depList = String.Join(", ", Dependencies.AsEnumerable());

                        pattern = @"\s+(?<functionView>\w+)\s*function\s+(?<functionName>\w+)\s?(?<functionArguments>\(.*(?R)*\))\s*(?<functionBody>{(?:[^{}]+|(?-1))*+})?";
                        var PageFunctions = PCRE.PcreRegex.Matches(contents, pattern).ToArray();
                        string queries = "";
                        foreach (var function in PageFunctions)
                        {
                            string privacy = function[1];
                            string functionName = function[2];
                            string functionArguments = function[3];
                            string FunctionBody = function[4];
                            pattern = @"\s+(?<functionNameSpace>(?=[^\s\(\>])(\$this-\>)?([\w\d]*[\:|\\]{0,2}){0,4})(?=\s*\()";
                            var InternalFunctions = PCRE.PcreRegex.Matches(FunctionBody, pattern).ToArray();
                            int InternalFunctionsCount = 0;
                            List<string> InternalFunctionsList = new List<string>();
                            if (InternalFunctions.Length > 0)
                            {
                                foreach (var func in InternalFunctions)
                                {
                                    bool builtin = false;
                                    foreach (var builtInPHP in PHPFNames.php_functions)
                                    {
                                        if (builtInPHP == func[1])
                                        {
                                            builtin = true;
                                            break;
                                        }
                                    }

                                    if (builtin == false)
                                    {
                                        InternalFunctionsList.Add(func[1]);
                                    }
                                }

                                InternalFunctionsList = InternalFunctionsList.Distinct().ToList();
                                InternalFunctionsCount = InternalFunctionsList.Count;
                            }
                            var InternalFunctionsListString = String.Join(", ", InternalFunctionsList.AsEnumerable());
                            //(?<functionName>(?=[^\(])([\w\d]*[:|\\]*)*[\w\d]*)\s?\((?<Arguments>.*)?\)
                            queries += @"INSERT INTO code_objects (namespace,scope,name,args,body,total_using,using_list,internal_function_list,internal_function_count,filename) VALUES('" + NameSpace[1] + "','" + privacy.Replace("'", "''") + "','" + functionName.Replace("'", "''") + "','" + functionArguments.Replace("'", "''") + "','" + FunctionBody.Replace("'", "''") + "','" + Dependencies.Length + "','" + depList.Replace("'", "''") + "','" + InternalFunctionsListString + "','" + InternalFunctionsCount + "','" + file + "');";
                        }
                        DBStorage.SQLite.Query("namespaces", queries);
                        //System.Data.DataTable results2 = DBStorage.SQLite.Query("namespaces", "SELECT id,body from code_objects");
                        //if (results2 != null && results2.Rows.Count == 0)
                        //{
                        //    DBStorage.SQLite.Query("namespaces", @"INSERT INTO namespaces VALUES(" + counter + ",'" + NameSpace[1] + "','" + fi.Name + "')");
                        //}
                    }
                    catch (System.IO.FileNotFoundException e)
                    {
                        // If file was deleted by a separate application
                        //  or thread since the call to TraverseTree()
                        // then just continue.
                        Console.WriteLine(e.Message);
                        continue;
                    }
                }

                // Push the subdirectories onto the stack for traversal.
                // This could also be done before handing the files.
                foreach (string str in subDirs)
                    dirs.Push(str);
            }
        }

        // Find internal functions
        // (?<!function )\s(->)?([a-z|A-Z|0-9]+)\(
        public static string toJson(dynamic item)
        {
            foreach (var VARIABLE in (Devsense.PHP.Syntax.Ast.GlobalCode[])item)
            {
                var ll = VARIABLE.ToString();
            }
            return null;
        }

        public static LangElement GetContainingRoutine(LangElement element)
        {
            while (!(element is MethodDecl || element is FunctionDecl || element is LambdaFunctionExpr || element is GlobalCode || element == null))
            {
                element = element.ContainingElement;
            }

            //
            return element;
        }

        private static string StripComments(string code)
        {
            var re = @"\/\/.*";
            code = Regex.Replace(code, re, "", RegexOptions.None,
                TimeSpan.FromSeconds(12.5));
            re = @"/\*(.*?)\*/";
            code = Regex.Replace(code, re, "", RegexOptions.None,
                TimeSpan.FromSeconds(12.5));
            re = @"\/\*(?s:.*?)\*\/";
            code = Regex.Replace(code, re, "", RegexOptions.None,
                TimeSpan.FromSeconds(12.5));
            return code;
        }
    }
}