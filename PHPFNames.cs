﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHP_Optimizer
{
    public class PHPFNames
    {
        public static string[] php_functions = new string[] { "if", "isset", "for", "empty", "try", "catch", "array", "else", "elseif", "foreach","function", "_", "abs", "acos", "acosh", "addcslashes", "addslashes", "apache_get_modules", "apache_get_version", "apache_getenv", "apache_lookup_uri", "apache_note", "apache_request_headers", "apache_response_headers", "apache_setenv", "array_change_key_case", "array_chunk", "array_column", "array_combine", "array_count_values", "array_diff", "array_diff_assoc", "array_diff_key", "array_diff_uassoc", "array_diff_ukey", "array_fill", "array_fill_keys", "array_filter", "array_flip", "array_intersect", "array_intersect_assoc", "array_intersect_key", "array_intersect_uassoc", "array_intersect_ukey", "array_key_exists", "array_key_first", "array_key_last", "array_keys", "array_map", "array_merge", "array_merge_recursive", "array_multisort", "array_pad", "array_pop", "array_product", "array_push", "array_rand", "array_reduce", "array_replace", "array_replace_recursive", "array_reverse", "array_search", "array_shift", "array_slice", "array_splice", "array_sum", "array_udiff", "array_udiff_assoc", "array_udiff_uassoc", "array_uintersect", "array_uintersect_assoc", "array_uintersect_uassoc", "array_unique", "array_unshift", "array_values", "array_walk", "array_walk_recursive", "arsort", "asin", "asinh", "asort", "assert", "assert_options", "atan", "atan2", "atanh", "base64_decode", "base64_encode", "base_convert", "basename", "bcadd", "bccomp", "bcdiv", "bcmod", "bcmul", "bcpow", "bcpowmod", "bcscale", "bcsqrt", "bcsub", "bin2hex", "bind_textdomain_codeset", "bindec", "bindtextdomain", "boolval", "cal_days_in_month", "cal_from_jd", "cal_info", "cal_to_jd", "call_user_func", "call_user_func_array", "ceil", "chdir", "checkdate", "checkdnsrr", "chgrp", "chmod", "chop", "chown", "chr", "chunk_split", "class_alias", "class_exists", "class_implements", "class_parents", "class_uses", "clearstatcache", "closedir", "closelog", "compact", "connection_aborted", "connection_status", "constant", "convert_cyr_string", "convert_uudecode", "convert_uuencode", "copy", "cos", "cosh", "count", "count_chars", "crc32", "create_function", "crypt", "ctype_alnum", "ctype_alpha", "ctype_cntrl", "ctype_digit", "ctype_graph", "ctype_lower", "ctype_print", "ctype_punct", "ctype_space", "ctype_upper", "ctype_xdigit", "curl_close", "curl_copy_handle", "curl_errno", "curl_error", "curl_escape", "curl_exec", "curl_file_create", "curl_getinfo", "curl_init", "curl_multi_add_handle", "curl_multi_close", "curl_multi_errno", "curl_multi_exec", "curl_multi_getcontent", "curl_multi_info_read", "curl_multi_init", "curl_multi_remove_handle", "curl_multi_select", "curl_multi_setopt", "curl_multi_strerror", "curl_pause", "curl_reset", "curl_setopt", "curl_setopt_array", "curl_share_close", "curl_share_errno", "curl_share_init", "curl_share_setopt", "curl_share_strerror", "curl_strerror", "curl_unescape", "curl_version", "current", "date", "date_add", "date_create", "date_create_from_format", "date_create_immutable", "date_create_immutable_from_format", "date_date_set", "date_default_timezone_get", "date_default_timezone_set", "date_diff", "date_format", "date_get_last_errors", "date_interval_create_from_date_string", "date_interval_format", "date_isodate_set", "date_modify", "date_offset_get", "date_parse", "date_parse_from_format", "date_sub", "date_sun_info", "date_sunrise", "date_sunset", "date_time_set", "date_timestamp_get", "date_timestamp_set", "date_timezone_get", "date_timezone_set", "dcgettext", "dcngettext", "debug_backtrace", "debug_print_backtrace", "debug_zval_dump", "decbin", "dechex", "decoct", "define", "defined", "deflate_add", "deflate_init", "deg2rad", "dgettext", "dir", "dirname", "disk_free_space", "disk_total_space", "diskfreespace", "dngettext", "dns_check_record", "dns_get_mx", "dns_get_record", "dom_import_simplexml", "doubleval", "each", "easter_date", "easter_days", "end", "error_clear_last", "error_get_last", "error_log", "error_reporting", "escapeshellarg", "escapeshellcmd", "exec", "exif_imagetype", "exif_read_data", "exif_tagname", "exif_thumbnail", "exp", "explode", "expm1", "extension_loaded", "extract", "ezmlm_hash", "fclose", "feof", "fflush", "fgetc", "fgetcsv", "fgets", "fgetss", "file", "file_exists", "file_get_contents", "file_put_contents", "fileatime", "filectime", "filegroup", "fileinode", "filemtime", "fileowner", "fileperms", "filesize", "filetype", "filter_has_var", "filter_id", "filter_input", "filter_input_array", "filter_list", "filter_var", "filter_var_array", "finfo_buffer", "finfo_close", "finfo_file", "finfo_open", "finfo_set_flags", "floatval", "flock", "floor", "flush", "fmod", "fnmatch", "fopen", "forward_static_call", "forward_static_call_array", "fpassthru", "fprintf", "fputcsv", "fputs", "fread", "frenchtojd", "fscanf", "fseek", "fsockopen", "fstat", "ftell", "ftok", "ftp_alloc", "ftp_append", "ftp_cdup", "ftp_chdir", "ftp_chmod", "ftp_close", "ftp_connect", "ftp_delete", "ftp_exec", "ftp_fget", "ftp_fput", "ftp_get", "ftp_get_option", "ftp_login", "ftp_mdtm", "ftp_mkdir", "ftp_mlsd", "ftp_nb_continue", "ftp_nb_fget", "ftp_nb_fput", "ftp_nb_get", "ftp_nb_put", "ftp_nlist", "ftp_pasv", "ftp_put", "ftp_pwd", "ftp_quit", "ftp_raw", "ftp_rawlist", "ftp_rename", "ftp_rmdir", "ftp_set_option", "ftp_site", "ftp_size", "ftp_ssl_connect", "ftp_systype", "ftruncate", "func_get_arg", "func_get_args", "func_num_args", "function_exists", "fwrite", "gc_collect_cycles", "gc_disable", "gc_enable", "gc_enabled", "gc_mem_caches", "gc_status", "gd_info", "get_browser", "get_called_class", "get_cfg_var", "get_class", "get_class_methods", "get_class_vars", "get_current_user", "get_declared_classes", "get_declared_interfaces", "get_declared_traits", "get_defined_constants", "get_defined_functions", "get_defined_vars", "get_extension_funcs", "get_headers", "get_html_translation_table", "get_include_path", "get_included_files", "get_loaded_extensions", "get_magic_quotes_gpc", "get_magic_quotes_runtime", "get_mangled_object_vars", "get_meta_tags", "get_object_vars", "get_parent_class", "get_required_files", "get_resource_type", "get_resources", "getallheaders", "getcwd", "getdate", "getenv", "gethostbyaddr", "gethostbyname", "gethostbynamel", "gethostname", "getimagesize", "getimagesizefromstring", "getlastmod", "getmxrr", "getmygid", "getmyinode", "getmypid", "getmyuid", "getopt", "getprotobyname", "getprotobynumber", "getrandmax", "getrusage", "getservbyname", "getservbyport", "gettext", "gettimeofday", "gettype", "glob", "gmdate", "gmmktime", "gmp_abs", "gmp_add", "gmp_and", "gmp_binomial", "gmp_clrbit", "gmp_cmp", "gmp_com", "gmp_div", "gmp_div_q", "gmp_div_qr", "gmp_div_r", "gmp_divexact", "gmp_export", "gmp_fact", "gmp_gcd", "gmp_gcdext", "gmp_hamdist", "gmp_import", "gmp_init", "gmp_intval", "gmp_invert", "gmp_jacobi", "gmp_kronecker", "gmp_lcm", "gmp_legendre", "gmp_mod", "gmp_mul", "gmp_neg", "gmp_nextprime", "gmp_or", "gmp_perfect_power", "gmp_perfect_square", "gmp_popcount", "gmp_pow", "gmp_powm", "gmp_prob_prime", "gmp_random", "gmp_random_bits", "gmp_random_range", "gmp_random_seed", "gmp_root", "gmp_rootrem", "gmp_scan0", "gmp_scan1", "gmp_setbit", "gmp_sign", "gmp_sqrt", "gmp_sqrtrem", "gmp_strval", "gmp_sub", "gmp_testbit", "gmp_xor", "gmstrftime", "gregoriantojd", "gzclose", "gzcompress", "gzdecode", "gzdeflate", "gzencode", "gzeof", "gzfile", "gzgetc", "gzgets", "gzgetss", "gzinflate", "gzopen", "gzpassthru", "gzputs", "gzread", "gzrewind", "gzseek", "gztell", "gzuncompress", "gzwrite", "hash", "hash_algos", "hash_copy", "hash_equals", "hash_file", "hash_final", "hash_hkdf", "hash_hmac", "hash_hmac_algos", "hash_hmac_file", "hash_init", "hash_pbkdf2", "hash_update", "hash_update_file", "hash_update_stream", "header", "header_register_callback", "header_remove", "headers_list", "headers_sent", "hebrev", "hebrevc", "hex2bin", "hexdec", "highlight_file", "highlight_string", "hrtime", "html_entity_decode", "htmlentities", "htmlspecialchars", "htmlspecialchars_decode", "http_build_query", "http_response_code", "hypot", "iconv", "iconv_get_encoding", "iconv_mime_decode", "iconv_mime_decode_headers", "iconv_mime_encode", "iconv_set_encoding", "iconv_strlen", "iconv_strpos", "iconv_strrpos", "iconv_substr", "idate", "igbinary_serialize", "igbinary_unserialize",
            "ignore_user_abort", "image2wbmp", "image_type_to_extension", "image_type_to_mime_type", "imageaffine", "imageaffinematrixconcat", "imageaffinematrixget", "imagealphablending", "imageantialias", "imagearc", "imagebmp", "imagechar", "imagecharup", "imagecolorallocate", "imagecolorallocatealpha", "imagecolorat", "imagecolorclosest", "imagecolorclosestalpha", "imagecolorclosesthwb", "imagecolordeallocate", "imagecolorexact", "imagecolorexactalpha", "imagecolormatch", "imagecolorresolve", "imagecolorresolvealpha", "imagecolorset", "imagecolorsforindex", "imagecolorstotal", "imagecolortransparent", "imageconvolution", "imagecopy", "imagecopymerge", "imagecopymergegray", "imagecopyresampled", "imagecopyresized", "imagecreate", "imagecreatefrombmp", "imagecreatefromgd", "imagecreatefromgd2", "imagecreatefromgd2part", "imagecreatefromgif", "imagecreatefromjpeg", "imagecreatefrompng", "imagecreatefromstring", "imagecreatefromtga", "imagecreatefromwbmp", "imagecreatefromwebp", "imagecreatefromxbm", "imagecreatefromxpm", "imagecreatetruecolor", "imagecrop", "imagecropauto", "imagedashedline", "imagedestroy", "imageellipse", "imagefill", "imagefilledarc", "imagefilledellipse", "imagefilledpolygon", "imagefilledrectangle", "imagefilltoborder", "imagefilter", "imageflip", "imagefontheight", "imagefontwidth", "imageftbbox", "imagefttext", "imagegammacorrect", "imagegd", "imagegd2", "imagegetclip", "imagegif", "imageinterlace", "imageistruecolor", "imagejpeg", "imagelayereffect", "imageline", "imageloadfont", "imageopenpolygon", "imagepalettecopy", "imagepalettetotruecolor", "imagepng", "imagepolygon", "imagerectangle", "imageresolution", "imagerotate", "imagesavealpha", "imagescale", "imagesetbrush", "imagesetclip", "imagesetinterpolation", "imagesetpixel", "imagesetstyle", "imagesetthickness", "imagesettile", "imagestring", "imagestringup", "imagesx", "imagesy", "imagetruecolortopalette", "imagettfbbox", "imagettftext", "imagetypes", "imagewbmp", "imagewebp", "imagexbm", "imap_8bit", "imap_alerts", "imap_append", "imap_base64", "imap_binary", "imap_body", "imap_bodystruct", "imap_check", "imap_clearflag_full", "imap_close", "imap_create", "imap_createmailbox", "imap_delete", "imap_deletemailbox", "imap_errors", "imap_expunge", "imap_fetch_overview", "imap_fetchbody", "imap_fetchheader", "imap_fetchmime", "imap_fetchstructure", "imap_fetchtext", "imap_gc", "imap_get_quota", "imap_get_quotaroot", "imap_getacl", "imap_getmailboxes",
            "imap_getsubscribed", "imap_header", "imap_headerinfo", "imap_headers", "imap_last_error", "imap_list", "imap_listmailbox", "imap_listscan", "imap_listsubscribed", "imap_lsub", "imap_mail", "imap_mail_compose", "imap_mail_copy", "imap_mail_move", "imap_mailboxmsginfo", "imap_mime_header_decode", "imap_msgno", "imap_mutf7_to_utf8", "imap_num_msg", "imap_num_recent", "imap_open", "imap_ping", "imap_qprint", "imap_rename", "imap_renamemailbox", "imap_reopen", "imap_rfc822_parse_adrlist", "imap_rfc822_parse_headers", "imap_rfc822_write_address", "imap_savebody", "imap_scan", "imap_scanmailbox", "imap_search", "imap_set_quota", "imap_setacl", "imap_setflag_full", "imap_sort", "imap_status", "imap_subscribe", "imap_thread", "imap_timeout", "imap_uid", "imap_undelete", "imap_unsubscribe", "imap_utf7_decode", "imap_utf7_encode", "imap_utf8", "imap_utf8_to_mutf7", "implode", "in_array", "inet_ntop", "inet_pton", "inflate_add", "inflate_get_read_len", "inflate_get_status", "inflate_init", "ini_alter", "ini_get", "ini_get_all", "ini_restore", "ini_set", "intdiv", "interface_exists", "intval", "ip2long", "iptcembed", "iptcparse", "is_a", "is_array", "is_bool", "is_callable", "is_countable", "is_dir", "is_double", "is_executable", "is_file", "is_finite", "is_float", "is_infinite", "is_int", "is_integer", "is_iterable", "is_link", "is_long", "is_nan", "is_null", "is_numeric", "is_object", "is_readable", "is_real", "is_resource", "is_scalar", "is_soap_fault", "is_string", "is_subclass_of", "is_uploaded_file", "is_writable", "is_writeable", "iterator_apply", "iterator_count", "iterator_to_array", "jddayofweek", "jdmonthname", "jdtofrench", "jdtogregorian", "jdtojewish", "jdtojulian", "jdtounix", "jewishtojd", "join", "jpeg2wbmp", "json_decode", "json_encode", "json_last_error", "json_last_error_msg", "juliantojd", "key", "key_exists", "krsort", "ksort", "lcfirst", "lcg_value", "lchgrp", "lchown", "levenshtein", "libxml_clear_errors", "libxml_disable_entity_loader", "libxml_get_errors", "libxml_get_last_error", "libxml_set_external_entity_loader", "libxml_set_streams_context", "libxml_use_internal_errors", "link", "linkinfo", "localeconv", "localtime", "log", "log10", "log1p", "long2ip", "lstat", "ltrim", "mail", "max", "mb_check_encoding", "mb_chr", "mb_convert_case", "mb_convert_encoding", "mb_convert_kana", "mb_convert_variables", "mb_decode_mimeheader", "mb_decode_numericentity", "mb_detect_encoding", "mb_detect_order", "mb_encode_mimeheader", "mb_encode_numericentity", "mb_encoding_aliases", "mb_ereg", "mb_ereg_match", "mb_ereg_replace", "mb_ereg_replace_callback", "mb_ereg_search", "mb_ereg_search_getpos", "mb_ereg_search_getregs", "mb_ereg_search_init", "mb_ereg_search_pos", "mb_ereg_search_regs", "mb_ereg_search_setpos", "mb_eregi", "mb_eregi_replace", "mb_get_info", "mb_http_input", "mb_http_output", "mb_internal_encoding", "mb_language", "mb_list_encodings", "mb_ord", "mb_output_handler", "mb_parse_str", "mb_preferred_mime_name", "mb_regex_encoding", "mb_regex_set_options", "mb_scrub", "mb_send_mail", "mb_split", "mb_str_split", "mb_strcut", "mb_strimwidth", "mb_stripos", "mb_stristr", "mb_strlen", "mb_strpos", "mb_strrchr", "mb_strrichr", "mb_strripos", "mb_strrpos", "mb_strstr", "mb_strtolower", "mb_strtoupper", "mb_strwidth", "mb_substitute_character", "mb_substr", "mb_substr_count", "mbereg", "mbereg_match", "mbereg_replace", "mbereg_search", "mbereg_search_getpos", "mbereg_search_getregs", "mbereg_search_init", "mbereg_search_pos", "mbereg_search_regs", "mbereg_search_setpos", "mberegi", "mberegi_replace", "mbregex_encoding", "mbsplit", "md5", "md5_file", "memory_get_peak_usage", "memory_get_usage", "metaphone", "method_exists", "mhash", "mhash_count", "mhash_get_block_size", "mhash_get_hash_name", "mhash_keygen_s2k", "microtime", "mime_content_type", "min", "mkdir", "mktime", "money_format", "move_uploaded_file", "msg_get_queue", "msg_queue_exists", "msg_receive", "msg_remove_queue", "msg_send", "msg_set_queue", "msg_stat_queue", "mt_getrandmax", "mt_rand", "mt_srand", "mysqli_affected_rows", "mysqli_autocommit", "mysqli_begin_transaction", "mysqli_change_user", "mysqli_character_set_name", "mysqli_close", "mysqli_commit", "mysqli_connect", "mysqli_connect_errno", "mysqli_connect_error", "mysqli_data_seek", "mysqli_debug", "mysqli_dump_debug_info", "mysqli_errno", "mysqli_error", "mysqli_error_list", "mysqli_escape_string", "mysqli_execute", "mysqli_fetch_all", "mysqli_fetch_array", "mysqli_fetch_assoc", "mysqli_fetch_field", "mysqli_fetch_field_direct", "mysqli_fetch_fields", "mysqli_fetch_lengths", "mysqli_fetch_object", "mysqli_fetch_row", "mysqli_field_count", "mysqli_field_seek", "mysqli_field_tell", "mysqli_free_result", "mysqli_get_charset", "mysqli_get_client_info", "mysqli_get_client_stats", "mysqli_get_client_version", "mysqli_get_connection_stats", "mysqli_get_host_info", "mysqli_get_links_stats", "mysqli_get_proto_info", "mysqli_get_server_info", "mysqli_get_server_version", "mysqli_get_warnings", "mysqli_info", "mysqli_init", "mysqli_insert_id", "mysqli_kill", "mysqli_more_results", "mysqli_multi_query", "mysqli_next_result", "mysqli_num_fields", "mysqli_num_rows", "mysqli_options", "mysqli_ping", "mysqli_poll", "mysqli_prepare", "mysqli_query", "mysqli_real_connect", "mysqli_real_escape_string", "mysqli_real_query", "mysqli_reap_async_query", "mysqli_refresh", "mysqli_release_savepoint", "mysqli_report", "mysqli_rollback", "mysqli_savepoint", "mysqli_select_db", "mysqli_set_charset", "mysqli_set_opt", "mysqli_sqlstate", "mysqli_ssl_set", "mysqli_stat", "mysqli_stmt_affected_rows", "mysqli_stmt_attr_get", "mysqli_stmt_attr_set", "mysqli_stmt_bind_param", "mysqli_stmt_bind_result", "mysqli_stmt_close", "mysqli_stmt_data_seek", "mysqli_stmt_errno", "mysqli_stmt_error", "mysqli_stmt_error_list", "mysqli_stmt_execute", "mysqli_stmt_fetch", "mysqli_stmt_field_count", "mysqli_stmt_free_result", "mysqli_stmt_get_result", "mysqli_stmt_get_warnings", "mysqli_stmt_init", "mysqli_stmt_insert_id", "mysqli_stmt_more_results", "mysqli_stmt_next_result", "mysqli_stmt_num_rows", "mysqli_stmt_param_count", "mysqli_stmt_prepare", "mysqli_stmt_reset", "mysqli_stmt_result_metadata", "mysqli_stmt_send_long_data", "mysqli_stmt_sqlstate", "mysqli_stmt_store_result", "mysqli_store_result", "mysqli_thread_id", "mysqli_thread_safe", "mysqli_use_result", "mysqli_warning_count", "natcasesort", "natsort", "net_get_interfaces", "next", "ngettext", "nl2br", "nl_langinfo", "number_format", "ob_clean", "ob_end_clean", "ob_end_flush", "ob_flush", "ob_get_clean", "ob_get_contents", "ob_get_flush", "ob_get_length", "ob_get_level", "ob_get_status", "ob_gzhandler", "ob_implicit_flush", "ob_list_handlers", "ob_start", "octdec", "opcache_compile_file", "opcache_get_configuration", "opcache_get_status", "opcache_invalidate", "opcache_is_script_cached", "opcache_reset", "opendir", "openlog", "openssl_cipher_iv_length", "openssl_csr_export", "openssl_csr_export_to_file", "openssl_csr_get_public_key", "openssl_csr_get_subject", "openssl_csr_new", "openssl_csr_sign", "openssl_decrypt", "openssl_dh_compute_key", "openssl_digest", "openssl_encrypt", "openssl_error_string", "openssl_free_key", "openssl_get_cert_locations", "openssl_get_cipher_methods", "openssl_get_curve_names", "openssl_get_md_methods", "openssl_get_privatekey", "openssl_get_publickey", "openssl_open", "openssl_pbkdf2", "openssl_pkcs12_export", "openssl_pkcs12_export_to_file", "openssl_pkcs12_read", "openssl_pkcs7_decrypt", "openssl_pkcs7_encrypt", "openssl_pkcs7_read", "openssl_pkcs7_sign", "openssl_pkcs7_verify", "openssl_pkey_derive", "openssl_pkey_export", "openssl_pkey_export_to_file", "openssl_pkey_free", "openssl_pkey_get_details", "openssl_pkey_get_private", "openssl_pkey_get_public", "openssl_pkey_new", "openssl_private_decrypt", "openssl_private_encrypt", "openssl_public_decrypt", "openssl_public_encrypt", "openssl_random_pseudo_bytes", "openssl_seal", "openssl_sign", "openssl_spki_export", "openssl_spki_export_challenge", "openssl_spki_new", "openssl_spki_verify", "openssl_verify", "openssl_x509_check_private_key", "openssl_x509_checkpurpose", "openssl_x509_export", "openssl_x509_export_to_file", "openssl_x509_fingerprint", "openssl_x509_free", "openssl_x509_parse", "openssl_x509_read", "openssl_x509_verify",
            "ord", "output_add_rewrite_var", "output_reset_rewrite_vars", "pack", "parse_ini_file", "parse_ini_string", "parse_str", "parse_url", "passthru", "password_algos", "password_get_info", "password_hash", "password_needs_rehash", "password_verify", "pathinfo", "pclose", "pdo_drivers", "pfsockopen", "php_ini_loaded_file", "php_ini_scanned_files", "php_sapi_name", "php_strip_whitespace", "php_uname", "phpcredits", "phpinfo", "phpversion", "pi", "png2wbmp", "popen", "pos", "posix_access", "posix_ctermid", "posix_errno", "posix_get_last_error", "posix_getcwd", "posix_getegid", "posix_geteuid", "posix_getgid", "posix_getgrgid", "posix_getgrnam", "posix_getgroups", "posix_getlogin", "posix_getpgid", "posix_getpgrp", "posix_getpid", "posix_getppid", "posix_getpwnam", "posix_getpwuid", "posix_getrlimit", "posix_getsid", "posix_getuid", "posix_initgroups", "posix_isatty", "posix_kill", "posix_mkfifo", "posix_mknod", "posix_setegid", "posix_seteuid", "posix_setgid", "posix_setpgid", "posix_setrlimit", "posix_setsid", "posix_setuid", "posix_strerror", "posix_times", "posix_ttyname", "posix_uname", "pow", "preg_filter", "preg_grep", "preg_last_error", "preg_match", "preg_match_all", "preg_quote", "preg_replace", "preg_replace_callback", "preg_replace_callback_array", "preg_split", "prev", "print_r", "printf", "proc_close", "proc_get_status", "proc_nice", "proc_open", "proc_terminate", "property_exists", "putenv", "quoted_printable_decode", "quoted_printable_encode", "quotemeta", "rad2deg", "rand", "random_bytes", "random_int", "range", "rawurldecode", "rawurlencode", "read_exif_data", "readdir", "readfile", "readgzfile", "readline", "readline_add_history", "readline_callback_handler_install", "readline_callback_handler_remove", "readline_callback_read_char", "readline_clear_history", "readline_completion_function", "readline_info", "readline_list_history", "readline_on_new_line", "readline_read_history", "readline_redisplay", "readline_write_history", "readlink", "realpath", "realpath_cache_get", "realpath_cache_size", "register_shutdown_function", "register_tick_function", "rename", "reset", "restore_error_handler", "restore_exception_handler", "restore_include_path", "rewind", "rewinddir", "rmdir", "round", "rsort", "rtrim", "scandir", "sem_acquire", "sem_get", "sem_release", "sem_remove", "serialize", "session_abort", "session_cache_expire", "session_cache_limiter", "session_commit", "session_create_id", "session_decode", "session_destroy", "session_encode", "session_gc", "session_get_cookie_params", "session_id", "session_module_name", "session_name", "session_regenerate_id", "session_register_shutdown", "session_reset", "session_save_path", "session_set_cookie_params", "session_set_save_handler", "session_start", "session_status", "session_unset", "session_write_close", "set_error_handler", "set_exception_handler", "set_file_buffer", "set_include_path", "set_time_limit", "setcookie", "setlocale", "setrawcookie", "settype", "sha1", "sha1_file", "shell_exec", "shm_attach", "shm_detach", "shm_get_var", "shm_has_var", "shm_put_var", "shm_remove", "shm_remove_var", "shmop_close", "shmop_delete", "shmop_open", "shmop_read", "shmop_size", "shmop_write", "show_source", "shuffle", "similar_text", "simplexml_import_dom", "simplexml_load_file", "simplexml_load_string", "sin", "sinh", "sizeof", "sleep", "socket_accept", "socket_addrinfo_bind", "socket_addrinfo_connect", "socket_addrinfo_explain", "socket_addrinfo_lookup", "socket_bind", "socket_clear_error", "socket_close", "socket_cmsg_space", "socket_connect", "socket_create", "socket_create_listen", "socket_create_pair", "socket_export_stream", "socket_get_option", "socket_get_status", "socket_getopt", "socket_getpeername", "socket_getsockname", "socket_import_stream", "socket_last_error", "socket_listen", "socket_read", "socket_recv", "socket_recvfrom", "socket_recvmsg", "socket_select", "socket_send", "socket_sendmsg", "socket_sendto", "socket_set_block", "socket_set_blocking", "socket_set_nonblock", "socket_set_option", "socket_set_timeout", "socket_setopt", "socket_shutdown", "socket_strerror", "socket_write", "sodium_add", "sodium_base642bin", "sodium_bin2base64", "sodium_bin2hex", "sodium_compare", "sodium_crypto_aead_aes256gcm_decrypt", "sodium_crypto_aead_aes256gcm_encrypt", "sodium_crypto_aead_aes256gcm_is_available", "sodium_crypto_aead_aes256gcm_keygen", "sodium_crypto_aead_chacha20poly1305_decrypt", "sodium_crypto_aead_chacha20poly1305_encrypt", "sodium_crypto_aead_chacha20poly1305_ietf_decrypt", "sodium_crypto_aead_chacha20poly1305_ietf_encrypt", "sodium_crypto_aead_chacha20poly1305_ietf_keygen", "sodium_crypto_aead_chacha20poly1305_keygen", "sodium_crypto_aead_xchacha20poly1305_ietf_decrypt", "sodium_crypto_aead_xchacha20poly1305_ietf_encrypt", "sodium_crypto_aead_xchacha20poly1305_ietf_keygen", "sodium_crypto_auth", "sodium_crypto_auth_keygen", "sodium_crypto_auth_verify", "sodium_crypto_box", "sodium_crypto_box_keypair", "sodium_crypto_box_keypair_from_secretkey_and_publickey", "sodium_crypto_box_open", "sodium_crypto_box_publickey", "sodium_crypto_box_publickey_from_secretkey", "sodium_crypto_box_seal", "sodium_crypto_box_seal_open", "sodium_crypto_box_secretkey", "sodium_crypto_box_seed_keypair", "sodium_crypto_generichash", "sodium_crypto_generichash_final", "sodium_crypto_generichash_init", "sodium_crypto_generichash_keygen", "sodium_crypto_generichash_update", "sodium_crypto_kdf_derive_from_key", "sodium_crypto_kdf_keygen", "sodium_crypto_kx_client_session_keys", "sodium_crypto_kx_keypair", "sodium_crypto_kx_publickey", "sodium_crypto_kx_secretkey", "sodium_crypto_kx_seed_keypair", "sodium_crypto_kx_server_session_keys", "sodium_crypto_pwhash", "sodium_crypto_pwhash_scryptsalsa208sha256", "sodium_crypto_pwhash_scryptsalsa208sha256_str", "sodium_crypto_pwhash_scryptsalsa208sha256_str_verify", "sodium_crypto_pwhash_str", "sodium_crypto_pwhash_str_needs_rehash", "sodium_crypto_pwhash_str_verify", "sodium_crypto_scalarmult", "sodium_crypto_scalarmult_base", "sodium_crypto_secretbox", "sodium_crypto_secretbox_keygen", "sodium_crypto_secretbox_open", "sodium_crypto_secretstream_xchacha20poly1305_init_pull", "sodium_crypto_secretstream_xchacha20poly1305_init_push", "sodium_crypto_secretstream_xchacha20poly1305_keygen", "sodium_crypto_secretstream_xchacha20poly1305_pull", "sodium_crypto_secretstream_xchacha20poly1305_push", "sodium_crypto_secretstream_xchacha20poly1305_rekey", "sodium_crypto_shorthash", "sodium_crypto_shorthash_keygen", "sodium_crypto_sign", "sodium_crypto_sign_detached", "sodium_crypto_sign_ed25519_pk_to_curve25519", "sodium_crypto_sign_ed25519_sk_to_curve25519", "sodium_crypto_sign_keypair", "sodium_crypto_sign_keypair_from_secretkey_and_publickey", "sodium_crypto_sign_open", "sodium_crypto_sign_publickey", "sodium_crypto_sign_publickey_from_secretkey", "sodium_crypto_sign_secretkey", "sodium_crypto_sign_seed_keypair", "sodium_crypto_sign_verify_detached", "sodium_crypto_stream", "sodium_crypto_stream_keygen", "sodium_crypto_stream_xor", "sodium_hex2bin", "sodium_increment", "sodium_memcmp", "sodium_memzero", "sodium_pad", "sodium_unpad", "sort", "soundex", "spl_autoload", "spl_autoload_call", "spl_autoload_extensions", "spl_autoload_functions", "spl_autoload_register", "spl_autoload_unregister", "spl_classes", "spl_object_hash", "spl_object_id", "sprintf", "sqrt", "srand", "sscanf", "stat", "str_getcsv", "str_ireplace", "str_pad", "str_repeat", "str_replace", "str_rot13", "str_shuffle", "str_split", "str_word_count", "strcasecmp", "strchr", "strcmp", "strcoll", "strcspn", "stream_bucket_append", "stream_bucket_make_writeable", "stream_bucket_new", "stream_bucket_prepend", "stream_context_create", "stream_context_get_default", "stream_context_get_options", "stream_context_get_params", "stream_context_set_default", "stream_context_set_option", "stream_context_set_params", "stream_copy_to_stream", "stream_filter_append", "stream_filter_prepend", "stream_filter_register", "stream_filter_remove", "stream_get_contents", "stream_get_filters", "stream_get_line", "stream_get_meta_data", "stream_get_transports", "stream_get_wrappers", "stream_is_local", "stream_isatty", "stream_register_wrapper", "stream_resolve_include_path", "stream_select", "stream_set_blocking", "stream_set_chunk_size", "stream_set_read_buffer", "stream_set_timeout", "stream_set_write_buffer", "stream_socket_accept", "stream_socket_client", "stream_socket_enable_crypto", "stream_socket_get_name", "stream_socket_pair", "stream_socket_recvfrom", "stream_socket_sendto", "stream_socket_server", "stream_socket_shutdown", "stream_supports_lock", "stream_wrapper_register", "stream_wrapper_restore", "stream_wrapper_unregister", "strftime", "strip_tags", "stripcslashes", "stripos", "stripslashes", "stristr", "strlen", "strnatcasecmp", "strnatcmp", "strncasecmp", "strncmp", "strpbrk", "strpos", "strptime", "strrchr", "strrev", "strripos", "strrpos", "strspn", "strstr", "strtok", "strtolower", "strtotime", "strtoupper", "strtr", "strval", "substr", "substr_compare", "substr_count", "substr_replace", "symlink", "sys_get_temp_dir", "sys_getloadavg", "syslog", "system", "tan", "tanh", "tempnam", "textdomain", "time", "time_nanosleep", "time_sleep_until", "timezone_abbreviations_list", "timezone_identifiers_list", "timezone_location_get", "timezone_name_from_abbr", "timezone_name_get", "timezone_offset_get", "timezone_open", "timezone_transitions_get", "timezone_version_get", "tmpfile", "token_get_all", "token_name", "touch", "trait_exists", "trigger_error", "trim", "uasort", "ucfirst", "ucwords", "uksort", "umask", "uniqid", "unixtojd", "unlink", "unpack", "unregister_tick_function", "unserialize", "urldecode", "urlencode", "use_soap_error_handler", "user_error", "usleep", "usort", "utf8_decode", "utf8_encode", "var_dump", "var_export", "version_compare", "vfprintf", "virtual", "vprintf", "vsprintf", "wordwrap", "xml_error_string", "xml_get_current_byte_index", "xml_get_current_column_number", "xml_get_current_line_number", "xml_get_error_code", "xml_parse", "xml_parse_into_struct", "xml_parser_create", "xml_parser_create_ns", "xml_parser_free", "xml_parser_get_option", "xml_parser_set_option", "xml_set_character_data_handler", "xml_set_default_handler", "xml_set_element_handler", "xml_set_end_namespace_decl_handler", "xml_set_external_entity_ref_handler", "xml_set_notation_decl_handler", "xml_set_object", "xml_set_processing_instruction_handler", "xml_set_start_namespace_decl_handler", "xml_set_unparsed_entity_decl_handler", "xmlrpc_decode", "xmlrpc_decode_request", "xmlrpc_encode", "xmlrpc_encode_request", "xmlrpc_get_type", "xmlrpc_is_fault", "xmlrpc_parse_method_descriptions", "xmlrpc_server_add_introspection_data", "xmlrpc_server_call_method", "xmlrpc_server_create", "xmlrpc_server_destroy", "xmlrpc_server_register_introspection_callback", "xmlrpc_server_register_method", "xmlrpc_set_type", "xmlwriter_end_attribute", "xmlwriter_end_cdata", "xmlwriter_end_comment", "xmlwriter_end_document", "xmlwriter_end_dtd", "xmlwriter_end_dtd_attlist", "xmlwriter_end_dtd_element", "xmlwriter_end_dtd_entity", "xmlwriter_end_element", "xmlwriter_end_pi", "xmlwriter_flush", "xmlwriter_full_end_element", "xmlwriter_open_memory", "xmlwriter_open_uri", "xmlwriter_output_memory", "xmlwriter_set_indent", "xmlwriter_set_indent_string", "xmlwriter_start_attribute", "xmlwriter_start_attribute_ns", "xmlwriter_start_cdata", "xmlwriter_start_comment", "xmlwriter_start_document", "xmlwriter_start_dtd", "xmlwriter_start_dtd_attlist", "xmlwriter_start_dtd_element", "xmlwriter_start_dtd_entity", "xmlwriter_start_element", "xmlwriter_start_element_ns", "xmlwriter_start_pi", "xmlwriter_text", "xmlwriter_write_attribute", "xmlwriter_write_attribute_ns", "xmlwriter_write_cdata", "xmlwriter_write_comment", "xmlwriter_write_dtd", "xmlwriter_write_dtd_attlist", "xmlwriter_write_dtd_element", "xmlwriter_write_dtd_entity", "xmlwriter_write_element", "xmlwriter_write_element_ns", "xmlwriter_write_pi", "xmlwriter_write_raw", "zend_version", "zip_close", "zip_entry_close", "zip_entry_compressedsize", "zip_entry_compressionmethod", "zip_entry_filesize", "zip_entry_name", "zip_entry_open", "zip_entry_read", "zip_open", "zip_read", "zlib_decode", "zlib_encode", "zlib_get_coding_type" };
    }
}