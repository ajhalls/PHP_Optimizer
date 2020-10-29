# PHP_Optimizer
Optimizing PHP through static analysis as well as runtime information

I run a website that takes in a good amount of JSON data through an API. even with 24 cores at 2.9GHz, 512GB RAM and an SSD RAID, system load can still get up around 60, with it averaging around 7-8. As I am analyzing why I booted up a fresh Laravel 8 installation and usign the php function get_included_files() shows that it loads up 611 files to display the basic dashboard. 

To me that is crazy. In a past project I built a binary file parser that takes and rebuilds a database from binary data. Through trial and error, I found the enormous cost of seeking, even for things in memory. To be fast, you HAVE to stick to what you are actually using.

I want to tokenize the entire vendor folder, store it in a database, find which functions are actually being used, and which those depend on, throw them into a single file and be done with it. Ok... so I skipped a couple steps, but really, not that many.

This application is evolving as I decide what is needed to rebuild the output, but it can scan an directory tree and bring back all functions that are declared along with namespaces, arguments, the body of the function and then identifies any non built in PHP functions used within each function declaration. Hopefully there should be enough to start unwinding all dependencies. Scanning my `vendor` folder gives me 121,000 functions in the SQLite db.

As a fun side note, as I was discussing this with a coworker, we decided to log all functions that were called to build a page. Here is a regex to give it a try. I used VS Code's search and replace in all files to do it.

      What we are searching for:
      ^(\s*((public|private)\s?function\s*\w*\d?\s*\(.*[\s|\n]*\{))
      Replace with:
      $1\nfile_put_contents("/var/www/html/actuallyUsed.txt", __DIR__ .", ". __LINE__ .", " . __METHOD__ . ", ". __FUNCTION__ ."\\n", FILE_APPEND );
      Limit to only *.php

For my dashboard it had 91,000 functions (lines) called, or more accurately, functions were called 91,000 times. Using Editplus, I sorted and removed duplicates and found only 491 functions were used (360 for homepage). To me this illustrates the need to stop including 611 files, 121,000 functions by default. You could even take the output of that, figure out which functions were most used by your company and maybe even move those into compiled code.
