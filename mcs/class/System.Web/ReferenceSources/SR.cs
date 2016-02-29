//
// SR.cs: Manually collected resource strings for ReferenceSources
//
// Authors:
//	Pablo Ruiz García <pablo.ruiz@gmail.com>
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

//
// This file imports all System.Web SR strings from referencesources,
// however, most of them are commented out, as to reduce generated 
// assemblies file size. Uncomment them as needed while migrating
// System.Web code from referencesources.
//

using System.Globalization;

partial class SR
{
        internal static string GetString(string name, params object[] args)
        {
                return GetString (CultureInfo.InvariantCulture, name, args);
        }

        internal static string GetString(CultureInfo culture, string name, params object[] args) {
                return string.Format (culture, name, args);
        }

        internal static string GetString(string name)
        {
                return name;
        }

        internal static string GetString(CultureInfo culture, string name)
        {
                return name;
        }

	// ExceptionUtil.ParameterInvalid(string parameter)
	public const string Parameter_Invalid="The parameter '{0}' is invalid.";

	// ExceptionUtil.ParameterNullOrEmpty(string parameter)
	public const string Parameter_NullOrEmpty="The string parameter '{0}' cannot be null or empty.";

	// ExceptionUtil.PropertyNullOrEmpty(string property)
	public const string Property_NullOrEmpty="The value assigned to property '{0}' cannot be null or empty.";

	// ExceptionUtil.PropertyInvalid(string property)
	public const string Property_Invalid="The value assigned to property '{0}' is invalid.";

	// ExceptionUtil.UnexpectedError(string methodName)
	public const string Unexpected_Error="An unexpected error occurred in '{0}'.";

	// Use with ArgumentException or InvalidOperationException when the parameter name differs from the message name
	//ArgumentCannotBeNullOrEmptyString="Value cannot be null or an empty string.

	// Use with ArgumentException or InvalidOperationException when the parameter name differs from the message name
	public const string PropertyCannotBeNullOrEmptyString="Value of the '{0}' property cannot be null or an empty string.";

	// Use with ArgumentException or InvalidOperationException when the parameter name differs from the message name
	public const string PropertyCannotBeNull="Value of the '{0}' property cannot be null.";

	// Browser Caps
#if false
	public const string Invalid_string_from_browser_caps="The HttpBrowserCapabilities string '{1}' evaluated to '{2}'.  {0}  Check the browserCaps section of machine.config or web.config to correct the error.";
	public const string Unrecognized_construct_in_pattern="Server cannot recognize construct '{0}' in pattern '{1}'.";
	public const string Caps_cannot_be_inited_twice="Capabilities object cannot be initialized twice.";
	public const string Duplicate_browser_id="Id '{0}' has already been specified and must be unique.";
	public const string Invalid_browser_root="Invalid root element of browser definition file.  Must be contained in a <browsers> element.";
	public const string Browser_mutually_exclusive_attributes="Browser attributes '{0}' and '{1}' cannot be specified together.";
	public const string Browser_refid_prohibits_identification="The identification element cannot be used when the browser element includes a refID.";
	public const string Browser_invalid_element="The '{0}' element is not allowed in a browser or gateway definition.";
	public const string Browser_Circular_Reference="The browser id '{0}' is specified in a circular reference.";
	//Browser_attribute_required="The '{1}' attribute is required on the {0} element of the browser definition file.
	public const string Browser_attributes_required="The '{1}' or '{2}' attribute is required on the {0} element of the browser definition file.";
	//Browser_multiple_browser_matched="Browsers elements '{0}' and '{1}' matched at the same peer level in configuration - this is not allowed.
	public const string Browser_parentID_Not_Found="The browser or gateway element with ID '{0}' cannot be found.";
	public const string Browser_parentID_applied_to_default="parentID attribute is not allowed on a default browser element.";
	public const string Browser_InvalidID="The {0} '{1}' is not a valid identifier.";
	public const string Browser_Not_Allowed_InAppLevel="Invalid element '{0}' in the application browser file, this element can only be used in a machine level browser file.";
	public const string Browser_InvalidStrongNameKey="Invalid strong name key was generated.";
	public const string Browser_compile_error="BrowserCap assembly failed to be compiled.";
	public const string DefaultBrowser_parentID_Not_Found="The defaultBrowser element specified by parentID '{0}' cannot be found.";
	public const string Browser_empty_identification="A non-empty <identification> element is required for any browser definition.";
	public const string Browser_W3SVC_Failure_Helper_Text="Cannot restart W3SVC Service, this operation might require other privileges.";

	// Config related
	public const string DefaultSiteName="Default Web Site";

	public const string ControlAdapters_TypeNotFound="Unable to create type '{0}'.";

	public const string Failed_gac_install="Failed to install assembly to gac.";
	public const string Failed_gac_uninstall="Failed to uninstall assembly to gac.";
	//Config_Process_model_time_invalid="Process model times must be in the form [[hh:]mm:]ss
	//EncryptedNode_is_in_invalid_format="The section is marked as being protected. However, the <EncryptedData> child node was not found in the section's node. Make sure that the section is correctly encrypted.
	public const string WrongType_of_Protected_provider="The type specified does not extend ProtectedConfigurationProvider class.";
	public const string Make_sure_remote_server_is_enabled_for_config_access="Unable to access the configuration system on the remote server. Make sure that the remote server allows remote configuration.";
	//Config_unable_to_set_configuration_system="Unable to set configuration system.
	public const string Config_unable_to_get_section="Unable to retrieve configuration section '{0}'.";
	public const string Config_failed_to_resolve_site_id="Failed to resolve the site ID for '{0}'.";
	public const string Config_GetSectionWithPathArgInvalid="WebConfigurationManager::GetSection(sectionName, path) can only be called from within a web application.";
	public const string Unable_to_create_temp_file="Unable to create a new temp file.";
	public const string Config_allow_definition_error_application="It is an error to use a section registered as allowDefinition="'MachineToApplication' beyond application level.  This error can be caused by a virtual directory not being configured as an application in IIS.";
	public const string Config_allow_definition_error_machine="It is an error to use a section registered as allowDefinition="'MachineOnly' beyond machine.config.";
	public const string Config_allow_definition_error_webroot="It is an error to use a section registered as allowDefinition="'MachineToWebRoot' beyond the root web.config file.";
	public const string Config_base_unrecognized_element="Unrecognized element";
	public const string Config_base_required_attribute_missing="The required attribute '{0}' was not found.";
	//Config_base_required_attribute_missing_option="Required attribute '{0}' or '{1}' must be defined.
	public const string Config_base_required_attribute_empty="The required attribute '{0}' cannot be empty.";
	//Config_base_required_attribute_missing_scope="The WebSiteAdministrationAuthorizationSettings 'ScopeCollection' must not be empty.
	public const string Config_base_unrecognized_attribute="Unrecognized attribute '{0}'. Note that attribute names are case-sensitive.";
	public const string Config_base_elements_only="Only XML elements are allowed.";
	public const string Config_base_no_child_nodes="Child nodes are not allowed.";
	public const string Config_base_file_load_exception_no_message="Could not load the assembly. The property '{0}' must be a valid assembly.";
	public const string Config_base_bad_image_exception_no_message="Could not load the assembly. The file image '{0}' is invalid.";
	public const string Config_base_report_exception_type="Could not load the assembly.  The unexpected exception was '{0}'.";
	public const string Config_property_generic="The configuration property is invalid.";
	public const string Config_section_not_supported="The configuration section is not supported: {0}.";
	public const string Unable_To_Register_Assembly="Unable to register assembly '{0}'.";
	public const string Unable_To_UnRegister_Assembly="Unable to un-register assembly '{0}'.";
	public const string Could_not_create_type_instance="Server could not create {0}.";
	//Config_Default_SQL_Description="Stores and retrieves {0} data from the local Microsoft SQL Server database
	//Config_Default_Access_Description="Stores and retrieves {0} data from the local Microsoft Access database file
	//Config_Default_WindowsToken_Description="Retrieves {0} data from the Windows authenticated token for the request
	//Config_Default_AuthStore_Description="Stores and retrieves {0} data from the authorization store.
	//Config_Default_SiteMap_Description="SiteMap provider which reads in .sitemap XML files.
	//Config_OpenConfig_InvalidPath="Only an absolute path to the configuration is valid for the path.
	public const string Config_Invalid_enum_value="The enumeration value must be one of the following: {0}.";
	public const string Config_element_below_app_illegal="The element '{0}' cannot be defined below the application level.";

	//Config_Membership="membership
	//Config_Profile="profile
	public const string Config_provider_must_exist="The provider '{0}' specified for the defaultProvider does not exist in the providers collection.";
	//Config_Roles="roles
	public const string File_is_read_only="The file '{0}' is marked as read-only.";
	public const string Can_not_access_files_other_than_config="Only config files can be accessed by this feature.";

	public const string Error_loading_XML_file="The XML file {0} could not be loaded.  {1}";

	public const string Unknown_tag_in_caps_config="Server found the unknown tag <{0}> in capabilities configuration.";
	public const string Cannot_specify_test_without_match="Cannot specify test without match.";
	public const string Result_must_be_at_the_top_browser_section="<result> must be at the top of the <browsercaps> section";
	public const string Type_doesnt_inherit_from_type="Type '{0}' does not inherit from '{1}'.";
	public const string Type_cannot_be_resolved="The type '{0}' cannot be resolved. Please verify the spelling is correct or that the full type name is provided.";
	public const string Problem_reading_caps_config="Server cannot read capabilities configuration {0}.";

	//Missing_modules_config="Missing <httpModules> configuration
	//No_mapping_to_remove="No mapping {0}/{1} to remove.
	//Phase_attribute_out_of_range="Phase attribute is out of range
	public const string Special_module_cannot_be_added_manually="Special module of type '{0}' cannot be added or removed manually.";
	//Module_already_in_app="The module '{0}' is already in the application and cannot be added again
	public const string Special_module_cannot_be_removed_manually="Special module of type '{0}' cannot be removed manually.";
	public const string Module_not_in_app="There is no '{0}' module in the application to remove.";
	//Auth_unrecognized_tag="Unrecognized tag '{0}' in the config file
	public const string Invalid_credentials="Invalid user credentials are specified in the config file.";
	public const string Auth_Invalid_Login_Url="The login URL specified for authentication is not valid.";
	//Unrecognized_configuration_section="Unrecognized configuration section '{0}'
	//Unknown_globalization_attr=" The <globalization> tag contains unknown attribute '{0}'.
	public const string Invalid_value_for_globalization_attr="The <globalization> tag contains an invalid value for the '{0}' attribute.";
	public const string Invalid_credentials_2="Could not create Windows user token from the credentials specified in the config file. Error from the operating system '{0}'";
	public const string Invalid_registry_config="Error reading configuration information from the registry.";
	//cannot_use_Triple_DES="Could not initialize the Triple-DES cryptography package. Make sure you have the 128-bit encryption package installed.
	public const string Invalid_Passport_Redirect_URL="Redirect URL specified for Passport Authentication is invalid.";
	public const string Invalid_redirect_return_url="The return URL specified for request redirection is invalid.";

	public const string Config_section_not_present="The application's configuration files must contain '{0}' section.";
	//ConfigParentLookupWithNoParent="Attempt to lookup configuration record parent when there is no parent for this record.
	public const string Local_free_threads_cannot_exceed_free_threads="The value for 'minLocalRequestFreeThreads' cannot exceed the value for 'minFreeThreads'.";
	public const string Min_free_threads_must_be_under_thread_pool_limits="The value for 'minFreeThreads' must be less than the thread pool limit of {0} threads.";
	public const string Thread_pool_limit_must_be_greater_than_minFreeThreads="The value for 'maxWorkerThreads' and 'maxIoThreads' multiplied by the number of processors must be greater than the value of <httpRuntime minFreeThreads/>, which is currently set to {0}.";
	public const string Config_max_request_length_disk_threshold_exceeds_max_request_length="The property 'RequestLengthDiskThreshold' must be less than or equal to the 'MaxRequestLength' property.";
	public const string Config_max_request_length_smaller_than_max_request_length_disk_threshold="The property 'MaxRequestLength' must be greater than or equal to the 'RequestLengthDiskThreshold' property.";
	//Config_section_attribute_locked="The attribute '{0}' cannot be used at this path.  This happens when the site administrator has locked access to this attribute from an inherited configuration file.
	//Invalid_lockAttributes="The attribute '{0}' cannot be locked for this section.  The following attributes of this section can be locked: {1}.  Multiple attributes may be listed separated by commas.
	public const string Capability_file_root_element="The root element of a capabilities file must be '{0}'.";
	public const string File_element_only_valid_in_config="File elements are not allowed in external capability files.";
	//Unrecognized_attribute="Attribute was not recognized.
	public const string HttpRuntimeSection_TargetFramework_Invalid="The targetFramework attribute must either be empty or contain a valid framework version string.";

	//Cannot_find_type_converter="The type converter for type '{0}' cannot be found.
	//Cannot_perform_conversion="Cannot perform type conversion from string to type '{0}'.
	//Config_timespan_value_cannot_be_zero="The timespan value must not be zero.
	//Config_timespan_value_must_be_positive="The timespan value must be positive.

	public const string Clear_not_valid="Cannot specify <clear> on this node.";
	public const string Config_base_cannot_remove_inherited_items="Inherited items may not be removed.";
	public const string Nested_group_not_valid="Cannot nest the <group> element.";

	//Config_Redundant_node="The node <{0}> can only appear once.
	//No_field_to_remove="No field {0} to remove.
	//Config_Process_ComImpersonationLevel_invalid="The value specified for comImpersonationLevel is invalid.
	//Config_Process_ComAuthenticationLevel_invalid="The value specified for comAuthenticationLevel is invalid.

	public const string Dup_protocol_id="Duplicate protocol ID: '{0}'.";

	public const string WebPartsSection_NoVerbs="The rule must contain at least one verb.  The valid verbs are 'enterSharedScope' and 'modifyState'.";
	public const string WebPartsSection_InvalidVerb="The verb '{0}' is not valid.  The valid verbs are 'enterSharedScope' and 'modifyState'.";
	public const string Transformer_types_already_added="A transformer with name '{0}' has already been added, and has the same provider and consumer types as the transformer with name '{1}'.";
	public const string Transformer_attribute_error="Error reading WebPartTransformerAttribute: '{0}'";
	public const string File_changed_since_read="The file '{0}' has changed since it was read.";
	public const string Config_invalid_element="Invalid element is detected: '{0}'.";

	public const string Config_control_rendering_compatibility_version_is_less_than_minimum_version="The control rendering compatibility version must not be less than 3.5.";
#endif

#if false
	// ExpressionBuilders
	public const string InvalidExpressionSyntax="The expression '{0}' is invalid. Expressions use the syntax <%$ prefix:value %>.";
	public const string InvalidExpressionPrefix="The expression prefix '{0}' was not recognized.  Please correct the prefix or register the prefix in the <expressionBuilders> section of configuration.";
	public const string ExpressionBuilder_InvalidType="The type '{0}' is not an ExpressionBuilder.";
	public const string MissingExpressionPrefix="The expression '{0}' does not have a prefix.";
	public const string MissingExpressionValue="The expression '{0}' does not have a value.";
	public const string ExpressionBuilder_LiteralExpressionsNotAllowed="Literal expressions like '{0}' are not allowed. Use <asp:Literal runat=""server" Text=""<%{1}%>" /> instead.";
	public const string ResourceExpresionBuilder_PageResourceNotFound="The resource class for this page was not found.  Please check if the resource file exists and try again.";

	// File changes monitor

	public const string Failed_to_start_monitoring="Failed to start monitoring changes to '{0}'.";
	public const string Invalid_file_name_for_monitoring="Invalid file name for file monitoring: '{0}'. Common reasons for failure include:\r\n- The filename is not a valid Win32 file name.\r\n- The filename is not an absolute path.\r\n- The filename contains wildcard characters.\r\n- The file specified is a directory.\r\n- Access denied.";
	public const string Access_denied_for_monitoring="Failed to start monitoring changes to '{0}' because access is denied.";
	public const string Directory_does_not_exist_for_monitoring="Directory '{0}' does not exist. Failed to start monitoring file changes.";
	public const string NetBios_command_limit_reached="Failed to start monitoring changes to '{0}' because the network BIOS command limit has been reached. For more information on this error, please refer to Microsoft knowledge base article 810886. Hosting on a UNC share is not supported for the Windows XP Platform.";
	public const string Directory_rename_notification="Directory rename change notification for '{0}'.";
	public const string Change_notification_critical_dir="Change Notification for critical directories.";

	// Misc handlers

	public const string Path_not_found="Path '{0}' was not found.";
	public const string Path_forbidden="Path '{0}' is forbidden.";
	public const string Method_for_path_not_implemented="{0} {1} is not implemented.";
	public const string Method_not_allowed="The HTTP verb {0} used to access path '{1}' is not allowed.";
	public const string Cannot_call_defaulthttphandler_sync="DefaultHttpHandler must be called asynchronously using BeginProcessRequest.";
	public const string Handler_access_denied="The handler must be granted Script or Execute permission in order to execute.  This is set via &lt;system.webServer&gt;\\&lt;handlers accessPolicy&gt; configuration.";

	// Debug Auto-attach

	public const string Debugging_forbidden="{0} application debugging not enabled.";
	public const string Debug_Access_Denied="Debug access denied to '{0}'.";
	public const string Invalid_Debug_Request="DEBUG request is not valid.";
	public const string Invalid_Debug_ID="DebugSessionID corrupted or not provided.";
	public const string Error_Attaching_with_MDM="HRESULT="{0};ErrorString="Unable to do an AutoAttach.";

	// Caching

	public const string VaryByCustom_already_set="VaryByCustom is already set.";
	public const string CacheProfile_Not_Found="The '{0}' cache profile is not defined.  Please define it in the configuration file.";
	public const string Invalid_operation_cache_dependency="The cache dependencies for the response have already been determined and cannot be modified.";
	public const string Invalid_sqlDependency_argument="The '{0}' SqlDependency attribute for OutputCache directive is invalid.\r\n\r\nFor SQL Server 7.0 and SQL Server 2000, the valid format is "database:tablename", and table name must conform to the format of regular identifiers in SQL. To specify multiple pairs of values, use the ';' separator between pairs. (To specify ':', '\\' or ';', prefix it with the '\\' escape character.)\r\n\r\nFor dependencies that use SQL Server 9.0 notifications, specify the value 'CommandNotification'.";
	public const string Invalid_sqlDependency_argument2="The '{0}' SqlDependency attribute for OutputCache directive is invalid.\r\n\r\nDetailed error message: {1}";
	public const string Etag_already_set="Etag is already set.";
	public const string Cant_both_set_and_generate_Etag="Cannot set ETag and also generate it from files.";
	public const string Cacheability_for_field_must_be_private_or_nocache="Cacheability for a field must either be Private or NoCache.";
	public const string Cache_dependency_used_more_that_once="An attempt was made to reference a CacheDependency object from more than one Cache entry.";
	public const string Invalid_expiration_combination="absoluteExpiration must be DateTime.MaxValue or slidingExpiration must be timeSpan.Zero.";
	public const string Invalid_Dependency_Type="dependency argument to CacheDependency constructor can only be of type System.Web.Caching.CacheDependency";
	public const string Invalid_Parameters_To_Insert="One of the following parameters must be specified: dependencies, absoluteExpiration, slidingExpiration.";
	//No_Cache_Config_In_subdir="Cache configuration can only be set at machine or application.
	public const string Invalid_sql_cache_dep_polltime="The property 'pollTime' must be an integer value greater than or equal to 500(ms).";
	//Duplicate_registered_database="The '{0}' database has already been registered.
	//No_database_to_remove="No '{0}' database to remove.
	public const string Database_not_found="Cannot find the '{0}' database in the configuration.";
	public const string Cant_connect_sql_cache_dep_database_polling="Unable to connect to SQL database '{0}' for cache dependency polling.";
	public const string Cant_connect_sql_cache_dep_database_admin="Unable to connect to the SQL database for cache dependency registration.";
	public const string Cant_connect_sql_cache_dep_database_admin_cmdtxt="Failed during cache dependency registration.\r\n\r\nPlease make sure the database name and the table name are valid. Table names must conform to the format of regular identifiers in SQL.\r\n\r\nThe failing SQL command is:\r\n{0}\r\n";
	public const string Database_not_enabled_for_notification="The database '{0}' is not enabled for SQL cache notification.\r\n\r\nTo enable a database for SQL cache notification, please use the System.Web.Caching.SqlCacheDependencyAdmin.EnableNotifications method, or the command line tool aspnet_regsql. To use the tool, please run 'aspnet_regsql.exe -?' for more information.";
	public const string Table_not_enabled_for_notification="The '{0}' table in the database '{1}' is not enabled for SQL cache notification.\r\n\r\nPlease make sure the table exists, and the table name used for cache dependency matches exactly the table name used in cache notification registration.\r\n\r\nTo enable a table for SQL cache notification, please use SqlCacheDependencyAdmin.EnableTableForNotifications method, or the command line tool aspnet_regsql. To use the tool, please run 'aspnet_regsql.exe -?' for more information.\r\n\r\nTo get a list of enabled tables in the database, please use SqlCacheDependencyManager.GetTablesEnabledForNotifications method, or the command line tool aspnet_regsql.exe.";
	public const string Polling_not_enabled_for_sql_cache="SQL cache notification is not enabled. To enable SQL cache dependency, please set the 'enabled' attribute to "true" in the <sqlCacheDependency> section in the configuration file.";
	public const string Polltime_zero_for_database_sql_cache="SQL cache notification is not enabled for the database '{0}' because the pollTime attribute is set to zero in the configuration.";
	public const string Permission_denied_database_polling="SQL cache dependency polling failed for SQL database '{0}' because of permission problem.";
	public const string Permission_denied_database_enable_notification="You do not have sufficient permission on the database to enable SQL cache notification. You need to use a database owner account, such as 'sa' to add roles, to create the required tables and stored procedures, and to grant EXECUTE permission on those stored procedures.";
	public const string Permission_denied_table_enable_notification="You do not have sufficient permission on the database to enable SQL cache notification for the table '{0}'. You need the permission to create a trigger on the table '{0}', and to insert a row into the table 'AspNet_SqlCacheTablesForChangeNotification'.";
	public const string Permission_denied_database_disable_notification="You do not have sufficient permission on the database to disable SQL cache notification. You need the permission to remove the table 'AspNet_SqlCacheTablesForChangeNotification'.";
	public const string Permission_denied_table_disable_notification="You do not have sufficient permission on the database to disable SQL cache notification for the table '{0}'. You need the permission to remove a trigger from the table '{0}', and to remove a row from the table 'AspNet_SqlCacheTablesForChangeNotification'.";
	public const string Cant_get_enabled_tables_sql_cache_dep="Cannot get the tables enabled for SQL cache notification.";
	public const string Cant_disable_table_sql_cache_dep="Cannot disable a table for SQL cache notification because the database is not enabled for SQL cache notification.";
	public const string Cache_null_table="The table name parameter cannot be null or have a length of zero.";
	public const string Cache_null_table_in_tables="The tables parameter cannot contain a table which is null or has a length of zero.";
	public const string Cache_dep_table_not_found="The table '{0}' cannot be found in the database.";
	public const string UC_not_cached="The CachePolicy cannot be used, since the control is not being cached.";
	public const string UCCachePolicy_unavailable="The CachePolicy cannot be used after the PreRender phase.";
	public const string SqlCacheDependency_permission_denied="Failed to use SqlCacheDependency because permission is denied. In order to use SqlCacheDependency, the application needs to be granted unrestricted SqlClientPermission. Please check with your administrator if the application does not have this permission.";
	public const string No_UniqueId_Cache_Dependency="Unable to generate etag from dependencies. One of the dependencies couldn't generate a unique id.";
	public const string SqlCacheDependency_OutputCache_Conflict="The page already has the 'SqlDependency=""CommandNotification"' attribute specified in the OutputCache directive.  On such a page, it is an error to create a SqlCacheDependency object using a SqlCommand object.\r\n\r\nThere are two ways to solve this problem:\r\n1.Do not use the 'SqlDependency=""CommandNotification"' attribute in the OutputCache directive.\r\n2.On the SqlCommand object set SqlCommand.NotificationAutoEnlist to false.  The side effect is that that SqlCommand object will not affect the output caching of the page.";

#endif

#if false
	// Application

	public const string Cache_not_available="Cache is not available";
	public const string Http_handler_not_found_for_request_type="No http handler was found for request type '{0}'";
	public const string Request_not_available="Request is not available in this context";
	public const string Response_not_available="Response is not available in this context.";
	public const string Session_not_available="Session state is not available in this context.";
	public const string Server_not_available="Server operation is not available in this context.";
	public const string User_not_available="User is not available in this context.";
	public const string Sync_not_supported="Synchronous request processing is not supported.";
	public const string Type_not_factory_or_handler="{0} does not implement IHttpHandlerFactory or IHttpHandler.";
	public const string Type_from_untrusted_assembly="Type '{0}' cannot be instantiated under a partially trusted security policy (AllowPartiallyTrustedCallersAttribute is not present on the target assembly).";
	public const string Type_not_module="{0} does not implement IHttpModule.";
	public const string Request_timed_out="Request timed out.";
	public const string DynamicModuleRegistrationOff="RegisterModule cannot be called when <httpRuntime allowDynamicModuleRegistration="'false'>.";

	public const string Invalid_ControlState="The state information is invalid for this page and might be corrupted.";
	public const string Too_late_for_ViewStateUserKey="The ViewStateUserKey property needs to be set during Page_Init.";
	public const string Too_late_for_RegisterRequiresViewStateEncryption="The RegisterRequiresViewStateEncryption() method needs to be called before or during Page_PreRender.";

	public const string MethodCannotBeCalledAfterAppStart="This method cannot be called after Application_Start.";


	// Request

	public const string Invalid_urlencoded_form_data="The URL-encoded form data is not valid.";
	public const string Invalid_request_filter="The request filter is not valid.";
	public const string Cannot_map_path_without_context="Server cannot map the path without the full request context.";
	public const string Cross_app_not_allowed="The virtual path '{0}' maps to another application, which is not allowed.";
	public const string Max_request_length_exceeded="Maximum request length exceeded.";
	public const string Dangerous_input_detected="A potentially dangerous {0} value was detected from the client ({1}).";
	public const string Dangerous_input_detected_descr="ASP.NET has detected data in the request that is potentially dangerous because it might include HTML markup or script. The data might represent an attempt to compromise the security of your application, such as a cross-site scripting attack. If this type of input is appropriate in your application, you can include code in a web page to explicitly allow it. For more information, see http://go.microsoft.com/fwlink/?LinkID="212874.";
	public const string CollectionCountExceeded_HttpValueCollection="The maximum number of form, query string, or posted file items has already been read from the request. To change the maximum allowed request collection count from its current value of {0}, change the "aspnet:MaxHttpCollectionKeys" setting. See http://go.microsoft.com/fwlink/?LinkId="238386 for more information.";
	public const string CollectionCountExceeded_JavaScriptObjectDeserializer="The maximum number of items has already been deserialized into a single dictionary by the JavaScriptSerializer. To change the maximum allowed JSON dictionary entry count from its current value of {0}, change the "aspnet:MaxJsonDeserializerMembers" setting. See http://go.microsoft.com/fwlink/?LinkId="238386 for more information.";
	public const string Invalid_substitution_callback="Invalid callback. Only static methods on controls, or methods on other objects, are allowed for substitution callbacks.";
	public const string Url_too_long="The length of the URL for this request exceeds the configured maxUrlLength value.";
	public const string QueryString_too_long="The length of the query string for this request exceeds the configured maxQueryStringLength value.";
	public const string Using_BufferlessStream_API_Not_Supported="This API is not supported when using the HttpBufferlessInputStream.";
	public const string Using_InputStream_API_Not_Supported="Request.BufferlessInputStream cannot be used because the Request's contents have already been read.";

	// Response

	public const string Cannot_get_snapshot_if_not_buffered="Server cannot get response snapshot if responses are not buffered.";
	public const string Cannot_use_snapshot_after_headers_sent="Server cannot use snapshot after HTTP headers have been sent.";
	public const string Cannot_use_snapshot_for_TextWriter="Server cannot use snapshot for TextWriter responses.";
	public const string Cannot_set_status_after_headers_sent="Server cannot set status after HTTP headers have been sent.";
	public const string Cannot_set_content_type_after_headers_sent="Server cannot set content type after HTTP headers have been sent.";
	public const string Filtering_not_allowed="Filtering is not allowed.";
	public const string Cannot_append_header_after_headers_sent="Server cannot append header after HTTP headers have been sent.";
	public const string Cannot_append_cookie_after_headers_sent="Server cannot append cookies after HTTP headers have been sent.";
	public const string Cannot_modify_cookies_after_headers_sent="Server cannot modify cookies after HTTP headers have been sent.";
	public const string Cannot_clear_headers_after_headers_sent="Server cannot clear headers after HTTP headers have been sent.";
	public const string Cannot_call_method_after_headers_sent_generic="This functionality is unavailable after HTTP headers have been sent.";
	public const string Cannot_flush_completed_response="Server cannot flush a completed response.";
	public const string No_Route_Found_For_Redirect="No matching route found for RedirectToRoute.";
	public const string Cannot_redirect_after_headers_sent="Cannot redirect after HTTP headers have been sent.";
	public const string Cannot_set_header_encoding_after_headers_sent="Cannot change headers encoding after HTTP headers have been sent.";
	public const string Invalid_header_encoding="'{0}' cannot be used as Header Encoding.";
	public const string Cannot_redirect_to_newline="Redirect URI cannot contain newline characters.";
	public const string Invalid_status_string=" HTTP status string is not valid.";
	public const string Invalid_value_for_CacheControl="Property value for CacheControl is not valid. Value="{0}.";
	public const string OutputStream_NotAvail="OutputStream is not available when a custom TextWriter is used.";
	public const string Information_Disclosure_Warning="This error page might contain sensitive information because ASP.NET is configured to show verbose error messages using &lt;customErrors mode=""Off"/&gt;. Consider using &lt;customErrors mode=""On"/&gt; or &lt;customErrors mode=""RemoteOnly"/&gt; in production environments.";
	public const string InvalidOffsetOrCount="The sum of {0} and {1} is greater than the length of the buffer.";

	// Runtime

	public const string Access_denied_to_app_dir="Server cannot access application directory '{0}'. The directory does not exist or is not accessible because of security settings.";
	public const string Access_denied_to_unicode_app_dir="The server cannot access the application directory {0}.  This may be due to the presence of Unicode characters in the URL.  Unicode characters are supported only when running IIS 6 or newer in worker process isolation mode.";
	public const string Access_denied_to_path="Access to path '{0}' was denied. The location does not exist or is not accessible because of security settings.";
	public const string Insufficient_trust_for_attribute="The current trust level does not allow use of the '{0}' attribute";
	public const string XSP_init_error="ASP.NET Initialization Error: {0}";
	//Duplicate_bin_dirs="The application contains both a 'bin' and a '{0}' directories, which is not allowed.
	public const string Unable_create_app_object="Could not create application object.";
	public const string Could_not_create_type="Could not create type '{0}'.";
	public const string StateManagedCollection_InvalidIndex="Insertion index was out of range. Must be non-negative and less than or equal to size.";
	public const string StateManagedCollection_NoKnownTypes="When implementing a derived StateManagedCollection, the implementation of CreateKnownType() must match the implementation of GetKnownTypes().";
	public const string VirtualPath_Length_Zero="The file's virtual path must have a length greater than zero.";
	public const string Invalid_app_VirtualPath="The virtual path '{0}' is not a valid absolute virtual path within the current application.";
	public const string Collection_CantAddNull="Cannot add null to this collection.";
	public const string Collection_InvalidType="Only objects of type {0} can be used with this collection.";

#endif

#if true

	// VirtualPath

	public const string VirtualPath_AllowAppRelativePath="The application relative virtual path '{0}' is not allowed here.";
	public const string VirtualPath_AllowRelativePath="The relative virtual path '{0}' is not allowed here.";
	public const string VirtualPath_AllowAbsolutePath="The absolute virtual path '{0}' is not allowed here.";
	public const string VirtualPath_CantMakeAppRelative="The absolute virtual path '{0}' cannot be made application relative, because the path to the application is not known.";
	public const string VirtualPath_CantMakeAppAbsolute="The application relative virtual path '{0}' cannot be made absolute, because the path to the application is not known.";
	public const string Bad_VirtualPath_in_VirtualFileBase="The VirtualPathProvider returned a {0} object with VirtualPath set to '{1}' instead of the expected '{2}'.";

	public const string ControlRenderedOutsideServerForm="Control '{0}' of type '{1}' must be placed inside a form tag with runat=\"server.\"";
	public const string RequiresNT="This operation requires Windows NT, Windows 2000, or Windows XP.";
	public const string ListEnumVersionMismatch="Collection was modified; enumeration operation may not execute.";
	public const string ListEnumCurrentOutOfRange="The enumerator's current position is out of bounds of the list.";
	public const string HTMLTextWriterUnbalancedPop="A PopEndTag was called without a corresponding PushEndTag.";
	public const string Server_too_busy="Server Too Busy";
	public const string InvalidArgumentValue="Invalid value for '{0}' parameter.";
	public const string CompilationMutex_Create="Mutex could not be created.";
	public const string CompilationMutex_Null="Mutex state is invalid.";
	public const string CompilationMutex_Drained="Application is restarting.";
	public const string CompilationMutex_Failed="Failed to acquire mutex lock.";
	public const string Failed_to_create_temp_dir="Failed to create temporary files directory '{0}'. Access denied.";
	public const string Failed_to_execute_child_request="Failed to execute child request.";
	public const string Cannot_impersonate="An error occurred while attempting to impersonate.  Execution of this request cannot continue.";
	public const string No_codegen_access="The current identity ({0}) does not have write access to '{1}'.";
	public const string Transaction_not_supported_in_low_trust="Transactions are not supported under current trust level settings.";
	public const string Debugging_not_supported_in_low_trust="Debugging is not supported under current trust level settings.";
	public const string Session_state_need_higher_trust="Access to session state is not supported under current trust level settings.";
	public const string ExecuteUrl_not_supported="Execute URL is not supported on this platform.";
	public const string Cannot_execute_url_in_this_context="Insufficient context to Execute URL.";
	public const string Failed_to_execute_url="Failed to Execute URL.";
	public const string Aspnet_not_installed="ASP.NET ({0}) is not installed on this machine.";
#endif

#if false

	// App Manager

	public const string Failed_to_initialize_AppDomain="Failed to initialize the AppDomain:";
	public const string Cannot_create_AppDomain="Failed to create AppDomain.";
	public const string Cannot_create_HostEnv="Failed to create HostingEnvironment.";
	public const string Unknown_protocol_id="Unknown protocol ID '{0}'.";
	public const string Only_1_HostEnv="Only one HostingEnvironment is allowed in an AppDomain.";
	public const string Not_IRegisteredObject="Type '{0}' does not implement IRegisteredObject interface.";
	public const string Wellknown_object_already_exists="Well known object of type '{0}' already exists in this App Domain.";
	public const string Invalid_IIS_app="'{0}' is not a valid IIS application.";
	public const string App_Virtual_Path="Application virtual path: '{0}'";
	public const string Hosting_Phys_Path_Changed="Physical application path changed from {0} to {1}.";
	public const string App_Domain_Restart="AppDomainRestart";
	public const string Hosting_Env_Restart="HostingEnvironment caused shutdown";
	public const string Hosting_Env_IdleTimeout="Idle timeout";
	public const string Unhandled_Exception="An unhandled exception occurred and the process was terminated.";
	public const string Provider_must_implement_the_interface="The provider class '{0}' must implement the class '{1}'.";
	public const string Permission_set_not_found="Could not find permission set named '{0}'.";
	public const string Require_stable_string_hash_codes="ASP.NET cannot operate when String hash code randomization is enabled for the current machine. Please verify that the registry key HKEY_LOCAL_MACHINE\\Software\\Microsoft\\.NETFramework\\UseRandomizedStringHashAlgorithm does not exist or is set to [DWORD] 0.";

	// Server vars collection
	public const string Server_variable_cannot_be_modified="This server variable cannot be modified during request execution.";
	public const string Cache_url_invalid="The format of the CACHE_URL server variable is invalid.";

	// HTTP Writer

	public const string Invalid_range="Specified range is not valid.";
	public const string Invalid_use_of_response_filter="Invalid use of response filter";
	public const string Invalid_response_filter="Response filter is not valid.";
	public const string Invalid_size="The size parameter must be between zero and the maximum Int32 value.";

	// Process model
	public const string Process_information_not_available="Process metrics are available only when the ASP.NET process model is enabled.  When running on versions of IIS 6 or newer in worker process isolation mode, this feature is not supported.";


	// Static files handler
	public const string Error_trying_to_enumerate_files="Server encountered an error while enumerating files.";
	public const string File_enumerator_access_denied="File enumerator access was denied.";
	public const string File_does_not_exist="File does not exist.";
	public const string File_is_hidden="File is hidden.";
	public const string Missing_star_mapping="Missing */ handler mapping.  The server cannot handle the directory.";
	public const string Resource_access_forbidden="Access to resource is forbidden.";


	// Server Utility

	public const string SMTP_TypeCreationError="Could not create an object of type '{0}'.  Please verify that the current platform configuration supports SMTP mail.";
	public const string Could_not_create_object_of_type="Could not create an object of type '{0}'.";
	public const string Could_not_create_object_from_clsid="Could not create an object with CLASSID '{0}'.";
	public const string Error_executing_child_request_for_path="Error executing child request for {0}.";
	public const string Error_executing_child_request_for_handler="Error executing child request for handler '{0}'.";
	public const string Invalid_path_for_child_request="Invalid path for child request '{0}'. A virtual path is expected.";
	public const string Transacted_page_calls_aspcompat="All pages that invoke other pages with aspcompat enabled must also have a <%@ page aspcompat="true %> directive.";
	public const string Invalid_path_for_remove="Invalid path for HttpResponse.RemoveOutputCacheItem '{0}'. An absolute virtual path is expected.";
	public const string Get_computer_name_failed="Could not obtain computer name.";

	// Cache


	// Hosting

	public const string Cannot_map_path="Failed to map the path '{0}'.";
	public const string Cannot_access_mappath_title="Failed to access IIS metabase.";
	public const string Cannot_access_mappath_details="The process account used to run ASP.NET must have read access to the IIS metabase (e.g. IIS://servername/W3SVC).   For information on modifying metabase permissions, please see <a href=""http://support.microsoft.com/?kbid="267904">http://support.microsoft.com/?kbid="267904</a>.";

	public const string Cannot_retrieve_request_data="Cannot retrieve the basic request data.";
	public const string Cannot_read_posted_data="Cannot read the posted data.";
	public const string Cannot_get_query_string="Cannot get the query string.";
	public const string Cannot_get_query_string_bytes="Cannot get query string bytes.";
	public const string Not_supported="The operation is not supported.";
	public const string GetGacLocaltion_failed="Unable to get the Global Assembly Cache path.";
	public const string Server_Support_Function_Error="An error occurred while communicating with the remote host. The error code is 0x{0}.";
	public const string Server_Support_Function_Error_Disconnect="The remote host closed the connection. The error code is 0x{0}.";

	// Security

	public const string MachineKeyDataProtectorFactory_FactoryCreationFailed="Could not create an instance of the configured DataProtector type.";
	public const string MachineKey_InvalidPurpose="If a list of purposes is specified, the list cannot contain null entries or entries that are comprised solely of whitespace characters.";
	public const string Provider_Schema_Version_Not_Match="The '{0}' requires a database schema compatible with schema version '{1}'.  However, the current database schema is not compatible with this version.  You may need to either install a compatible schema with aspnet_regsql.exe (available in the framework installation directory), or upgrade the provider to a newer version.";
	//Security_policy_level_already_defined="Security level already defined for '{0}'.
	//No_MachineKey_Config_In_subdir="MachineKey configuration can only occur in RootConfig or in application root.
	public const string Could_not_create_passport_identity="An error occurred while trying to create a passport identity.  Please ensure that Passport Manager is installed on the machine and correctly configured.";
	public const string Passport_method_failed="A call to a Passport Manager method has failed.  Please ensure that Passport Manager is installed on the machine and correctly configured.";
	//Auth_rule_must_have_allow_or_deny="Authorization rule must have an <allow> or <deny> tag.
	public const string Auth_rule_names_cant_contain_char="Authorization rule names cannot contain the '{0}' character.";
	public const string Auth_rule_must_specify_users_andor_roles="Authorization rule must specify a list of users and/or roles.";
	public const string PageIndex_bad="The pageIndex must be greater than or equal to zero.";
	public const string PageSize_bad="The pageSize must be greater than zero.";
	public const string PageIndex_PageSize_bad="The combination of pageIndex and pageSize cannot exceed the maximum value of System.Int32.";
	public const string Bad_machine_key="Machine decryption key is invalid. It should be either "AutoGenerate", or 16 (for DES) or 48 (for 3DES and AES) Hex chars long, and may be followed by ",IsolateApps". Exception message from the underlying layer: {0}";
	public const string PassportAuthFailed="<html><head><title>Passport Sign-in Required</title></head><body>\r\n<h1>Access Denied</h1><p><h3>You must sign in with valid or different Microsoft <sup>&reg;</sup> .NET Passport credentials to access this page.</h3><p> {0} </body></html>\r\n";
	public const string PassportAuthFailed_Title="Passport Sign-in Required";
	public const string PassportAuthFailed_Description="You must sign in with valid or different Microsoft .NET Passport credentials to access this page.";
	//Cannot_specify_below_app_level="The '{0}' section cannot be defined for directories below the application root.
	//Can_only_specify_at_app_level="The '{0}' section can only be specified in the web.config at the application root.
	//Can_only_specify_subsection_at_app_level="The '{0}' section of the '{1}' section can only be specified in the web.config at the application root.
	public const string Unable_to_encrypt_cookie_ticket="Unable to encrypt the authentication ticket. Try changing the decryption key configured for this application.";
	public const string Unable_to_get_cookie_authentication_validation_key="Machine validation key is invalid. It is '{0}' chars long. It should be either "AutoGenerate" or between 40 and 128 Hex chars long, and may be followed by ",IsolateApps".";
	public const string Unable_to_validate_data="Unable to validate data.";
	public const string Unable_to_get_policy_file="Unable to read the security policy file for trust level '{0}'.";
	public const string Wrong_validation_enum="The validation must be one of these values: SHA1, HMACSHA256, HMACSHA384, HMACSHA512, MD5, 3DES, AES, or alg:[HashAlgorithm].";
	public const string Wrong_validation_enum_FX45="When using <machineKey compatibilityMode=""Framework45" /> or the MachineKey.Protect and MachineKey.Unprotect APIs, the 'validation' attribute must be one of these values: SHA1, HMACSHA256, HMACSHA384, HMACSHA512, or alg:[KeyedHashAlgorithm].";
	public const string Wrong_decryption_enum="The decryption must be one of these values: Auto, DES, 3DES, AES or alg:[SymmetricAlgorithm].";
	public const string Role_is_not_empty="This role cannot be deleted because there are users present in it.";
	public const string Assess_Denied_Title="Access is denied.";
	public const string Assess_Denied_Description2="An error occurred while accessing the resources required to serve this request. The server may not be configured for access to the requested URL.";
	public const string Assess_Denied_Section_Title2="Error message 401.2.";
	public const string Assess_Denied_Misc_Content2="Unauthorized: Logon failed due to server configuration.  Verify that you have permission to view this directory or page based on the credentials you supplied and the authentication methods enabled on the Web server.  Contact the Web server's administrator for additional assistance.";
	public const string Assess_Denied_Description1="An error occurred while accessing the resources required to serve this request. This may have been caused by an incorrect user name and/or password.";
	public const string Assess_Denied_MiscTitle1="Error message 401.1";
	public const string Assess_Denied_MiscContent1="Logon credentials were not recognized. Make sure you are providing the correct user name and password. Otherwise, contact the Web server's administrator for help.";
#endif
	public const string Assess_Denied_Description3="An error occurred while accessing the resources required to serve this request. You might not have permission to view the requested resources.";
#if false
	public const string Assess_Denied_Section_Title3="Error message 401.3";
	public const string Assess_Denied_Misc_Content3="You do not have permission to view this directory or page using the credentials you supplied (access denied due to Access Control Lists). Ask the Web server's administrator to give you access to '{0}'.";
	public const string Assess_Denied_Misc_Content3_2="You do not have permission to view this directory or page using the credentials you supplied (access denied due to Access Control Lists). Ask the Web server's administrator to give you access.";
	//User_Already_Specified="A different password for the username '{0}', has already been specified in a configuration file.
	public const string Auth_bad_url="The URL specified in the config file is invalid.";
	public const string Virtual_path_outside_application_not_supported="Virtual path outside of the current application is not supported.";
	//Virtual_path_suspicious="The Virtual path supplied is suspicious.
	//Virtual_path_file_not_found="The file '{0}' specified by the virtual path was not found.
	public const string Invalid_decryption_key="Decryption key specified has invalid hex characters.";
	public const string Invalid_validation_key="Validation key specified has invalid hex characters.";
	public const string Passport_not_installed="The PassportManager object could not be initialized. Please ensure that Microsoft Passport is correctly installed on the server.";
	public const string DbFileName_can_not_contain_invalid_chars="The database filename cannot contain the following 3 characters: [ (open square brace), ] (close square brace) and ' (single quote)";
	public const string Provider_can_not_create_file_in_this_trust_level="The SSE Provider did not find the database file specified in the connection string. At the configured trust level (below High trust level), the SSE provider cannot automatically create the database file.";
	public const string LocalDB_cannot_have_userinstance_flag="The user instance login flag is not allowed when connecting to a LocalDB instance of SQL Server. The connection will be closed.";
	//Username_already_added="The username {0} has already been added.
	public const string MembershipPasswordAttribute_InvalidPasswordLength="The '{0}' field is an invalid password. Password must have {1} or more characters.";
	public const string MembershipPasswordAttribute_InvalidPasswordNonAlphanumericCharacters="The '{0}' field is an invalid password. Password must have {1} or more non-alphanumeric characters.";
	public const string MembershipPasswordAttribute_InvalidPasswordStrength="The '{0}' field does not meet the complexity requirements for a valid password.";
	public const string MembershipPasswordAttribute_InvalidRegularExpression="The MembershipPasswordAttribute was initialized with an invalid regular expression for password strength.";
	public const string LocalizableString_LocalizationFailed="Cannot retrieve property '{0}' because localization failed.  Type '{1}' is not public or does not contain a public static string property with the name '{2}'.";

	public const string Role_provider_name_invalid="The role provider name specified is invalid.";
	public const string Def_provider_not_found="Default provider not found";
	//Mem_Provider_only="Only provider elements are allowed.
	public const string Provider_no_type_name="Type name must be specified for this provider.";
	//MembershipAccessProvider_description="Access membership provider.
	public const string MembershipSqlProvider_description="SQL membership provider.";
	//RoleAccessProvider_description="Access role provider.
	public const string RoleSqlProvider_description="SQL role provider.";
	public const string RoleAuthStoreProvider_description="Authorization store role provider.";
	public const string RoleWindowsTokenProvider_description="Windows token role provider.";
	//ProfileAccessProvider_description="Access profile provider.
	public const string ProfileSqlProvider_description="SQL profile provider.";
	public const string Role_Principal_not_fully_constructed="This RolePrincipal object is not fully constructed.";
	//Provider_can_not_set_application_name="Full or High trust is required to set application name.
	public const string Only_one_connection_string_allowed="SqlWebEventProvider: Specify either a connectionString or connectionStringName, not both.";
	public const string Must_specify_connection_string_or_name="SqlWebEventProvider: Either a connectionString or connectionStringName must be specified.";
	public const string Cannot_use_integrated_security="SqlWebEventProvider: connectionString can only contain connection strings that use Sql Server authentication.  Trusted Connection security is not supported.";
	public const string Provider_application_name_too_long="The application name is too long.";
	public const string Provider_bad_password_format="Password format specified is invalid.";
	public const string Provider_can_not_retrieve_hashed_password="Configured settings are invalid: Hashed passwords cannot be retrieved. Either set the password format to different type, or set enablePasswordRetrieval to false.";
	public const string Provider_unrecognized_attribute="Attribute not recognized '{0}'";
	public const string Provider_can_not_decode_hashed_password="Hashed passwords cannot be decoded.";
	public const string Profile_group_not_found="The profile group '{0}' has not been defined.";
	public const string Profile_not_enabled="Profile has not been enabled.";
	//API_not_supported="Method not supported.
	public const string API_supported_for_current_user_only="Method is only supported if the user name parameter matches the user name in the current Windows Identity.";
	public const string API_failed_due_to_error="API failed due to error '{0}'";
	public const string Profile_property_already_added="This profile property has already been defined.";
	public const string Profile_provider_not_found="The profile provider was not found '{0}'";
	public const string Can_not_issue_cookie_or_redirect="Redirect failed because authentication ticket could not be stored in a cookie or URL due to configuration restrictions. Set EnableCrossAppRedirect to true in the <forms> configuration section in order to enable the ticket to be transferred to external locations via the URL.";
	public const string Profile_default_provider_not_found="The profile default provider was not found.";
	public const string Value_must_be_boolean="The value must be boolean (true or false) for property '{0}'.";
	public const string Value_must_be_positive_integer="The value must be a positive 32-bit integer for property '{0}'.";
	public const string Value_must_be_non_negative_integer="The value must be a non-negative 32-bit integer for property '{0}'.";
	public const string Value_too_big="The value '{0}' cannot be greater than '{1}'.";
	public const string Profile_name_can_not_be_empty="Profile property and group names must not be empty.";
	public const string Profile_name_can_not_contain_period="Profile property and group names must not contain '.'.";
	public const string Provider_user_not_found="The user was not found in the database.";
	public const string Provider_role_not_found="The role '{0}' was not found.";
	public const string Provider_unknown_failure="Stored procedure call failed.";
	public const string Provider_role_already_exists="The role '{0}' already exists.";
	public const string Profile_default_provider_not_specified="The default profile provider not specified.";
	public const string API_not_supported_at_this_level="This API is not supported at this trust level.";
	public const string Profile_bad_name="The property name specified is invalid.";
	public const string Profile_bad_group="The specified group name: {0} of this property is invalid.";
	//API_supported_for_UNC_Apps="This API is not supported for UNC applications.

	public const string Def_membership_provider_not_specified="Default Membership Provider must be specified.";
	public const string Def_membership_provider_not_found="Default Membership Provider could not be found.";
	public const string Provider_Error="The Provider encountered an unknown error.";
	public const string Roles_feature_not_enabled="The Role Manager feature has not been enabled.";
	public const string Def_role_provider_not_specified="Default Role Provider must be specified.";
	public const string Def_role_provider_not_found="Default Role Provider could not be found.";
	public const string Membership_PasswordRetrieval_not_supported="This Membership Provider has not been configured to support password retrieval.";
	//Membership_email_is_invalid="The E-mail supplied is invalid.
	public const string Membership_UserNotFound="The user was not found.";
	public const string Membership_WrongPassword="The password supplied is wrong.";
	public const string Membership_WrongAnswer="The password-answer supplied is wrong.";
	public const string Membership_InvalidPassword="The password supplied is invalid.  Passwords must conform to the password strength requirements configured for the default provider.";
	public const string Membership_InvalidQuestion="The password-question supplied is invalid.  Note that the current provider configuration requires a valid password question and answer.  As a result, a CreateUser overload that accepts question and answer parameters must also be used.";
	public const string Membership_InvalidAnswer="The password-answer supplied is invalid.";
	public const string Membership_InvalidUserName="The username supplied is invalid.";
	public const string Membership_InvalidEmail="The E-mail supplied is invalid.";
	public const string Membership_DuplicateUserName="The username is already in use.";
	public const string Membership_DuplicateEmail="The E-mail address is already in use.";
	public const string Membership_UserRejected="The User was rejected.";
	public const string Membership_InvalidProviderUserKey="The provider user key supplied is invalid.  It must be of type System.Guid.";
	public const string Membership_DuplicateProviderUserKey="The provider user key is already in use.";
	public const string Membership_AccountLockOut="The user account has been locked out.";
	public const string Membership_Custom_Password_Validation_Failure="The custom password validation failed.";
	public const string MinRequiredNonalphanumericCharacters_can_not_be_more_than_MinRequiredPasswordLength="The minRequiredNonalphanumericCharacters cannot be greater than minRequiredPasswordLength.";
	//Can_not_create_file_in_lower_trust="The provider does not support automatically creating the application services database at the current trust level.

	public const string ADMembership_Description="Active Directory membership provider.";
	public const string ADMembership_InvalidConnectionProtection="The specified connection protection type, '{0}', is invalid.";
	public const string ADMembership_Connection_username_must_not_be_empty="Connection-username must not be empty.";
	public const string ADMembership_Connection_password_must_not_be_empty="Connection-password must not be empty.";
	public const string ADMembership_Schema_mappings_must_not_be_empty="Schema mapping for property '{0}' must not be empty.";
	public const string ADMembership_Username_and_password_reqd="If either of the properties connection-username or connection-password is specified, the other must also be specified.";
	public const string ADMembership_PasswordReset_without_question_not_supported="The Active Directory membership provider does not support password reset without password question and answer.";
	public const string ADMembership_PasswordQuestionAnswerMapping_not_specified="Attribute schema mappings for password-question and password-answer must be specified to enable password question and answer functionality.";
	public const string ADMembership_Provider_not_initialized="The Active Directory Membership Provider has not been initialized.";
	public const string ADMembership_PasswordQ_not_supported="Schema mapping for password question has not been specified.";
	public const string ADMembership_PasswordA_not_supported="Schema mapping for password answer has not been specified.";
	public const string ADMembership_PasswordRetrieval_not_supported_AD="The Active Directory membership provider does not support password retrieval.";
	//ADMembership_Value_must_be_integer="Value must be positive integer for property '{0}'.
	public const string ADMembership_Username_mapping_invalid="The property 'attributeMapUsername' must be mapped to 'sAMAccountName' or 'userPrincipalName'.";
	public const string ADMembership_Username_mapping_invalid_ADAM="The property 'attributeMapUsername' must be mapped to 'userPrincipalName'.";
	public const string ADMembership_Wrong_syntax="'{0}' must be mapped to a schema attribute of type '{1}'.";
	public const string ADMembership_MappedAttribute_does_not_exist="The attribute '{0}' specified as a schema mapping for '{1}' does not exist.";
	public const string ADMembership_MappedAttribute_does_not_exist_on_user="The attribute '{0}' specified as a schema mapping for '{1}' is not an attribute of the user class.";
	public const string ADMembership_OnlyLdap_supported="Only LDAP connection strings are supported against Active Directory and ADAM.";
	public const string ADMembership_ServerlessADsPath_not_supported="Serverless LDAP connection strings are not supported by the Active Directory membership provider.";
	//ADMembership_ServerDown_or_NoSsl="The server is not operational or is not configured for SSL.
	public const string ADMembership_Secure_connection_not_established="Unable to establish secure connection with the server";
	public const string ADMembership_Ssl_connection_not_established="Unable to establish secure connection with the server using SSL.";
	public const string ADMembership_DefContainer_not_specified="A default container (defaultNamingContext) has not been set for the specified server.";
	public const string ADMembership_DefContainer_does_not_exist="The default users container does not exist in the specified domain.";
	public const string ADMembership_Container_must_be_specified="For ADAM a container must be specified in the connection string.";
	public const string ADMembership_Valid_Targets="This provider can target only Active Directory and ADAM directories.";
	//ADMembership_default_domain_not_found="Unable to get domain of the machine: error code =" {0}.
	public const string ADMembership_OnlineUsers_not_supported="This Active Directory membership provider does not support the notion of online users.";
	//ADMembership_ADAM_SignAndSeal_not_supported="SignAndSeal connectionProtection type is not supported for ADAM.
	//ADMembership_Cn_SignAndSeal_not_supported="SignAndSeal connectionProtection type is not supported when username is mapped to 'cn'.
	public const string ADMembership_UserProperty_not_supported="The property '{0}' is not supported by the Active Directory membership provider.";
	//ADMembership_UserProperty_not_writeable="Writing to the property '{0}' is not supported by the Active Directory membership provider.
	public const string ADMembership_Provider_SearchMethods_not_supported="The Active Directory membership provider has not been configured to support search methods.";
	public const string ADMembership_No_ADAM_Partition="Unable to find the ADAM application partition for the specified container.";
	public const string ADMembership_Setting_UserId_not_supported="The Active Directory membership provider does not support setting of the providerUserKey attribute.";
	public const string ADMembership_Default_Creds_not_supported="Default credentials are not supported when the connection protection is set to None.";
	public const string ADMembership_Container_not_superior="User objects cannot be created in the specified container.";
	public const string ADMembership_Container_does_not_exist="The container specified in the connection string does not exist.";
	public const string ADMembership_Property_not_found_on_object="Property '{0}' on object '{1}' not found.";
	public const string ADMembership_Property_not_found="Property '{0}' not found.";
	public const string ADMembership_BadPasswordAnswerMappings_not_specified="Attribute schema mappings for bad password answer tracking must be specified to enable password reset functionality.";
	public const string ADMembership_Unknown_Error="Unknown error ({0})";
	public const string ADMembership_GCPortsNotSupported="LDAP connections on the GC port are not supported against Active Directory.";
	//ADMembership_Can_not_use_encrypted_data_with_autogen_keys="You must specify a non-autogenerated machine key to store data in the encrypted format. Change machineKey configuration to use a non-autogenerated decryption key.
	public const string ADMembership_attribute_not_single_valued="Property '{0}' must be mapped to a single valued schema attribute.";
	public const string ADMembership_mapping_not_unique="Property '{0}' cannot be mapped to schema attribute '{1}' as the attribute is already in use.";
	public const string ADMembership_InvalidProviderUserKey="The provider user key supplied is invalid. It must be of type System.Security.Principal.SecurityIdentifier.";
	public const string ADMembership_unable_to_contact_domain="The specified domain or server could not be contacted.";
	public const string ADMembership_unable_to_set_password_port="Unable to set the password port and password method.";
	public const string ADMembership_invalid_path="The specified connection string does not represent a valid LDAP adspath.";
	public const string ADMembership_Setting_ApplicationName_not_supported="The Active Directory membership provider does not support setting of the ApplicationName property.";
	public const string ADMembership_Parameter_too_long="The parameter '{0}' is too long.";
	public const string ADMembership_No_secure_conn_for_password="Unable to setup a secure connection for setting/changing the password.";
	public const string ADMembership_Generated_password_not_complex="Unable to generate a password that satisfies the required password complexity policy.";
	public const string ADMembership_UPN_contains_backslash="Usernames must not contain '\\' when mapped to 'userPrincipalName'.";

	public const string Windows_Token_API_not_supported="The configured Role Provider (WindowsTokenRoleProvider) relies upon Windows authentication to determine the groups that the user is allowed to be a member of. ASP.NET Role Manager cannot be used to manage Windows users and groups. Please use the SQLRoleProvider if you would like to support custom user/role assignment.";
	//Profile_Property_already_defined="Profile property has already been defined.
	//Parameter_must_be_null_for_Access="The parameter '{0}' must be null for Access provider.
	public const string Parameter_can_not_contain_comma="The parameter '{0}' must not contain commas.";
	public const string Parameter_can_not_be_empty="The parameter '{0}' must not be empty.";
	public const string Parameter_too_long="The parameter '{0}' is too long: it must not exceed {1} chars in length.";
	public const string Parameter_array_empty="The array parameter '{0}' should not be empty.";
	public const string Parameter_collection_empty="The collection parameter '{0}' should not be empty.";
	public const string Parameter_duplicate_array_element="The array '{0}' should not contain duplicate values.";
	public const string Membership_password_too_long="The password is too long: it must not exceed 128 chars after encrypting.";
	public const string Provider_this_user_not_found="The user '{0}' was not found.";
	public const string Provider_this_user_already_in_role="The user '{0}' is already in role '{1}'.";
	public const string Provider_this_user_already_not_in_role="The user '{0}' is already not in role '{1}'.";
	//Profile_Property_name_invalid="The property name is invalid. It must contain only letters and digits, and must start with a letter.
	public const string SaveAs_requires_rooted_path="The SaveAs method is configured to require a rooted path, and the path '{0}' is not rooted.";
	//Provider_already_added="A provider with name '{0}' has already been added.
	//File_name_can_not_contain_dot_dot="File names in Access provider connection strings cannot contain '..'
	//AccessFile_is_not_valid="Unable to access database file '{0}'. The file is either inaccessible due to security, or the file does not exist. Note that Access databases are not supported for providers when running with application impersonation under either IIS 5.x or IIS 5.0 isolation mode on Windows Server 2003. Error message OleDb: '{1}'.
	//AccessFile_is_not_valid_2="Unable to access database file. The file is either inaccessible due to security, or the file does not exist. Note that Access databases are not supported for providers when running with application impersonation under either IIS 5.x or IIS 5.0 isolation mode on Windows Server 2003.
	public const string Connection_name_not_specified="The attribute 'connectionStringName' is missing or empty.";
	public const string Connection_string_not_found="The connection name '{0}' was not found in the applications configuration or the connection string is empty.";
	public const string AppSetting_not_found="The application setting '{0}' was not found in the applications configuration.";
	public const string AppSetting_not_convertible="Could not convert the AppSetting '{0}' to the type '{1}' on property '{2}'.";
	//Could_not_create_provider="Provider could not be instantiated.
	public const string Provider_must_implement_type="Provider must implement the class '{0}'.";
	//AccessFile_is_not_writtable="The Access database file '{0}' cannot be written to by the current identity ('{1}'). Message from the OleDbConnection: '{2}'.
	public const string Feature_not_supported_at_this_level="This feature is not supported at the configured trust level.";
	//Connection_string_can_not_be_specified_at_this_level="The configured trust level requires that a filename must be specified. A connection string cannot be specified.
	//Full_filename_can_not_be_specified_at_this_level="The configured trust level requires that a filename relative to the application install root be specified. A full file path cannot be specified.
	public const string Annoymous_id_module_not_enabled="The Profile property '{0}' allows anonymous users to store data. This requires that the AnonymousIdentification feature be enabled.";
	public const string Anonymous_ClearAnonymousIdentifierNotSupported="ClearAnonymousIdentifier is not supported when the feature is disabled or the user is anonymous.";
	//Access_File_not_found="The Access mdb file for this provider was not found.
	public const string Anonymous_id_too_long="The Anonymous Id specified is too long. It can be at most 128 chars long.";
	public const string Anonymous_id_too_long_2="The Anonymous Id specified is too long. It can be at most 512 chars long after encoding.";
	//Profile_property_not_found="This profile property has not been defined.
	//Jet_Not_Available="Access provider is not supported on this version of the operating system.  Please change the configuration to utilize a different provider.
	//Must_specify_answer="The password-question answer must be supplied.
	public const string Profile_could_not_create_type="Attempting to load this property's type resulted in the following error: {0}";
	public const string DataAccessError_CanNotCreateDataDir_Title="Access denied creating App_Data subdirectory";
	public const string DataAccessError_CanNotCreateDataDir_Description="For security reasons, the identity '{0}' (under which this web application is running), does not have permissions to create the App_Data subdirectory within the application root directory.";
	public const string DataAccessError_CanNotCreateDataDir_Description_2="For security reasons, the identity under which this web application is running, does not have permissions to create the App_Data subdirectory within the application root directory.";
	public const string DataAccessError_MiscSectionTitle="To grant the necessary permissions, follow these steps";
	public const string DataAccessError_MiscSection_1="In File Explorer, navigate to your application's directory.";
	public const string DataAccessError_MiscSection_2="Right-click on the "App_Data" subdirectory, within your application and select the "Properties" menu item.";
	public const string DataAccessError_MiscSection_2_CanNotCreateDataDir="Create a folder named "App_Data": Right-click, choose "New" menu item, choose "Folder" sub-menu item, and then type "App_Data" (without quotes).";
	public const string DataAccessError_MiscSection_2_CanNotWriteToDBFile_a="Navigate to the "App_Data" subdirectory.";
	public const string DataAccessError_MiscSection_2_CanNotWriteToDBFile_b="Right-click on the Access Database file (by default, the file is named "ASPNetDB.mdb") and select the "Properties" menu item.";
	public const string DataAccessError_MiscSection_3="In the "Properties" dialog box that opens,  select the "Security" tab.";
	public const string DataAccessError_MiscSection_4="In the "Enter the object names to select" box, enter '{0}' (without quotes).";
	public const string DataAccessError_MiscSection_4_2="In the "Enter the object names to select" box, enter name of the identity used to run this web application.";
	public const string DataAccessError_MiscSection_ClickAdd="Click Add";
	public const string DataAccessError_MiscSection_ClickOK="Click OK";
	public const string DataAccessError_MiscSection_5="Make sure the account name is selected and then under Allow, check Write";
	public const string SqlExpressError_CanNotWriteToDataDir_Title="Access denied creating Microsoft SQL Express Database file within App_Data subdirectory";
	public const string SqlExpressError_CanNotWriteToDbfFile_Title="Access denied writing to Microsoft SQL Express Database file";
	public const string SqlExpressError_CanNotWriteToDataDir_Description="For security reasons, the identity '{0}' (under which this web application is running), does not have permissions to create the SQL Express Database file within App_Data subdirectory.";
	public const string SqlExpressError_CanNotWriteToDbfFile_Description="For security reasons, the identity '{0}' (under which this web application is running), does not have permissions to write to the SQL Express Database file configured for this application.";
	public const string SqlExpressError_CanNotWriteToDataDir_Description_2="For security reasons, the identity under which this web application is running, does not have permissions to create the SQL Express Database file within App_Data subdirectory.";
	public const string SqlExpressError_CanNotWriteToDbfFile_Description_2="For security reasons, the identity under which this web application is running, does not have permissions to write to the SQL Express Database file configured for this application.";
	public const string SqlExpressError_Description_1="ASP.NET stores the Microsoft SQL Express Database file used for services such as Membership and Profile in the App_Data subdirectory of your application.";
	//AccessError_CanNotWriteToDataDir_Title="Access denied creating Microsoft Access Database file within App_Data subdirectory
	//AccessError_CanNotWriteToMdbFile_Title="Access denied writing to Microsoft Access Database file
	//AccessError_CanNotWriteToDataDir_Description="For security reasons, the identity '{0}' (under which this web application is running), does not have permissions to create the Access Database file within App_Data subdirectory.
	//AccessError_CanNotWriteToMdbFile_Description="For security reasons, the identity '{0}' (under which this web application is running), does not have permissions to write to the Access Database file configured for this application.
	//AccessError_CanNotWriteToDataDir_Description_2="For security reasons, the identity under which this web application is running, does not have permissions to create the Access Database file within App_Data subdirectory.
	//AccessError_CanNotWriteToMdbFile_Description_2="For security reasons, the identity under which this web application is running, does not have permissions to write to the Access Database file configured for this application.
	//AccessError_Description_1="ASP.NET stores the Microsoft Access Database file used for services such as Membership and Profile in the App_Data subdirectory of your application.
	//Access_File_can_not_start_with_this_char="File names in Access provider connection strings cannot start with '{0}'.
	public const string Membership_password_length_incorrect="Password length specified must be between 1 and 128 characters.";
	public const string Membership_min_required_non_alphanumeric_characters_incorrect="The value specified in parameter '{0}' should be in the range from zero to the value specified in the password length parameter.";
	public const string Membership_more_than_one_user_with_email="More than one user has the specified e-mail address.";
	public const string Password_too_short="The length of parameter '{0}' needs to be greater or equal to '{1}'.";
	public const string Password_need_more_non_alpha_numeric_chars="Non alpha numeric characters in '{0}' needs to be greater than or equal to '{1}'.";
	public const string Password_does_not_match_regular_expression="The parameter '{0}' does not match the regular expression specified in config file.";
	public const string Not_configured_to_support_password_resets="This provider is not configured to allow password resets. To enable password reset, set enablePasswordReset to "true" in the configuration file.";
	public const string Property_not_serializable="The type for the property '{0}' cannot be serialized using the binary serializer, since the type is not marked as serializable.";
	public const string Connection_not_secure_creating_secure_cookie="The application is configured to issue secure cookies. These cookies require the browser to issue the request over SSL (https protocol). However, the current request is not over SSL.";
	public const string Profile_anonoymous_not_allowed_to_set_property="This property cannot be set for anonymous users.";
	//Profile_empty_group="A property group must contain one or more properties.
	public const string AuthStore_Application_not_found="The application was not found in the authorization store.";
	public const string AuthStore_Scope_not_found="The scope was not found in the application.";
	public const string AuthStoreNotInstalled_Title="The authorization store component is not installed";
	public const string AuthStoreNotInstalled_Description="The AuthorizationStoreRoleProvider requires the authorization store components to be installed on the machine. The authorization store components are only installed and available by default on Windows Server 2003. Currently it appears that either the components have not been installed, or that the primary interop assembly has not been registered in the global assembly cache (GAC).  Both of these steps can be accomplished by downloading the Authorization Manager installation package from the web for your operating system, and installing the package on the machine.  Installations for other operating systems can be found by navigating to http://download.microsoft.com and searching with either the keyword "AzMan" or the keywords "authorization manager".";
	public const string AuthStore_policy_file_not_found="The policy file '{0}' in the connection string could not be found.";
	public const string Wrong_profile_base_type="The type specified in the configuration property "inherits" must inherit from the type System.Web.Profile.HttpProfileBase";
	public const string Command_not_recognized="The command was not recognized.";
	public const string Configuration_for_path_not_found="The configuration for virtual path '{0}' and site '{1}' cannot be opened.";
	public const string Configuration_for_physical_path_not_found="The configuration for physical path '{0}' cannot be opened.";
	public const string Configuration_for_machine_config_not_found="The configuration for machine.config cannot be opened.";
	public const string Configuration_Section_not_found="The configuration section '{0}' was not found.";
	//Configuration_SectionGroup_not_found="The configuration section-group '{0}' was not found.
	public const string RSA_Key_Container_not_found="The RSA key container was not found.";
	public const string RSA_Key_Container_access_denied="Could not access the RSA key container. Make sure that the ACLs on the container allow you to access it.";
	public const string RSA_Key_Container_already_exists="The RSA key container already exists.";

	public const string SqlError_Connection_String="An error occurred while attempting to initialize a System.Data.SqlClient.SqlConnection object. The value that was provided for the connection string may be wrong, or it may contain an invalid syntax.";
	//SqlExpress_File_Not_Valid="Unable to access SQL Express database file '{0}'. The file is either inaccessible due to security, or the file does not exist. Error message SqlClient: '{1}'.
	//SqlExpress_File_Not_Valid_2="Unable to access SQL Express database file.
	//SqlExpress_Connection_String_Incorrect="The SqlExpress connection string is incorrect.
	public const string SqlExpress_MDF_File_Auto_Creation_MiscSectionTitle="SQLExpress database file auto-creation error";
	public const string SqlExpress_MDF_File_Auto_Creation="The connection string specifies a local Sql Server Express instance using a database location within the application's App_Data directory.  The provider attempted to automatically create the application services database because the provider determined that the database does not exist. The following configuration requirements are necessary to successfully check for existence of the application services database and automatically create the application services database:";
	public const string SqlExpress_MDF_File_Auto_Creation_1="If the application is running on either Windows 7 or Windows Server 2008R2, special configuration steps are necessary to enable automatic creation of the provider database.  Additional information is available at:  http://go.microsoft.com/fwlink/?LinkId="160102. If the application's App_Data directory does not already exist, the web server account must have read and write access to the application's directory.  This is necessary because the web server account will automatically create the App_Data directory if it does not already exist.";
	public const string SqlExpress_MDF_File_Auto_Creation_2="If the application's App_Data directory already exists, the web server account only requires read and write access to the application's App_Data directory.  This is necessary because the web server account will attempt to verify that the Sql Server Express database already exists within the application's App_Data directory.  Revoking read access on the App_Data directory from the web server account will prevent the provider from correctly determining if the Sql Server Express database already exists.  This will cause an error when the provider attempts to create a duplicate of an already existing database.  Write access is required because the web server account's credentials are used when creating the new database.";
	public const string SqlExpress_MDF_File_Auto_Creation_3="Sql Server Express must be installed on the machine.";
	public const string SqlExpress_MDF_File_Auto_Creation_4="The process identity for the web server account must have a local user profile.  See the readme document for details on how to create a local user profile for both machine and domain accounts.";
	public const string SqlExpress_file_not_found_in_connection_string="SQL Express filename was not found in the connection string.";
	public const string SqlExpress_file_not_found="The SQL Express filename specified was not found.";

	// State

	//No_Session_Config_In_subdir="SessionState configuration can only be set in machine or application configuration.
	public const string Invalid_value_for_sessionstate_stateConnectionString="The <sessionState> stateConnectionString is invalid. It must have the format tcpip="<server>:<port>, where <server> is a valid IPv4 address, a machine name using only ASCII characters, or a valid IPv6 address enclosed within square brackets, and <port> is an unsigned integer ranging from 0 to 65535 (e.g., tcpip="127.0.0.1:42424, tcpip="localhost:42424, or tcpip="[::1]:42424).";
	public const string No_database_allowed_in_sqlConnectionString="The sqlConnectionString attribute or the connection string it refers to cannot contain the connection options 'Database', 'Initial Catalog' or 'AttachDbFileName'. In order to allow this, allowCustomSqlDatabase attribute must be set to true and the application needs to be granted unrestricted SqlClientPermission. Please check with your administrator if the application does not have this permission.";
	public const string No_database_allowed_in_sql_partition_resolver_string="The SQL connection string (server="'{1}', database="'{2}') returned by an instance of the IPartitionResolver type '{0}' cannot contain the connection options 'Database', 'Initial Catalog' or 'AttachDbFileName'. In order to allow this, allowCustomSqlDatabase attribute must be set to true and the application needs to be granted unrestricted SqlClientPermission. Please check with your administrator if the application does not have this permission.";
	public const string Error_parsing_session_sqlConnectionString="Error parsing <sessionState> sqlConnectionString attribute: {0}";
	public const string Error_parsing_sql_partition_resolver_string="Error parsing the SQL connection string returned by an instance of the IPartitionResolver type '{0}': {1}";
	public const string Timeout_must_be_positive="The argument to SetTimeout must be greater than 0.";
	public const string Cant_make_session_request="Unable to make the session state request to the session state server. Please ensure that the ASP.NET State service is started and that the client and server ports are the same.  If the server is on a remote machine, please ensure that it accepts remote requests by checking the value of HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\aspnet_state\\Parameters\\AllowRemoteConnection.  If the server is on the local machine, and if the before mentioned registry value does not exist or is set to 0, then the state server connection string must use either 'localhost' or '127.0.0.1' as the server name.";
	public const string Cant_make_session_request_partition_resolver="Unable to make the session state request to the session state server. The connection string (server="'{1}', port="'{2}') was returned by an instance of the IPartitionResolver type '{0}'. Please ensure that the ASP.NET State service is started and that the client and server ports are the same.  If the server is on a remote machine, please ensure that it accepts remote requests by checking the value of HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\aspnet_state\\Parameters\\AllowRemoteConnection.  If the server is on the local machine, and if the before mentioned registry value does not exist or is set to 0, then the state server connection string must use either 'localhost' or '127.0.0.1' as the server name.";
	public const string Need_v2_State_Server="Unable to use session state server because this version of ASP.NET requires session state server version 2.0 or above.";
	public const string Need_v2_State_Server_partition_resolver="Unable to use session state server because this version of ASP.NET requires session state server version 2.0 or above. The connection string (server="'{1}', port="'{2}') was returned by an instance of the IPartitionResolver type '{0}'.";
	public const string Cant_connect_sql_session_database="Unable to connect to SQL Server session database.";
	public const string Cant_connect_sql_session_database_partition_resolver="Unable to connect to SQL Server session database. The connection string (server="'{1}', database="'{2}') was returned by an instance of the IPartitionResolver type '{0}'.";
	public const string Login_failed_sql_session_database="Failed to login to session state SQL server for user '{0}'.";
	public const string Bad_partition_resolver_connection_string="Session state cannot connect to the server because a null connection string was returned by an instance of the IPartitionResolver type '{0}'.";
	public const string Bad_state_server_request="Unable to make the session state request to the session state server. The session state server is running, but the request is not formatted correctly.";
	public const string Bad_state_server_request_partition_resolver="Unable to make the session state request to the session state server. The session state server is running, but the request is not formatted correctly. The connection string (server="'{1}', port="'{2}') was returned by an instance of the IPartitionResolver type '{0}'.";
	public const string State_Server_detailed_error="Unable to make the session state request to the session state server. Details: last phase="'{0}', error code="{1}, size of outgoing data="{2}";
	public const string State_Server_detailed_error_phase0="Initialization";
	public const string State_Server_detailed_error_phase1="Connecting to the state server";
	public const string State_Server_detailed_error_phase2="Sending request to the state server";
	public const string State_Server_detailed_error_phase3="Reading response from the state server";
	public const string Error_parsing_state_server_partition_resolver_string="Error parsing the state server connection string returned by an instance of the IPartitionResolver type '{0}'. The connection string must have the format tcpip="<server>:<port>, where <server> is either a valid IP address or a machine name using only ASCII characters, and <port> is an unsigned integer ranging from 0 to 65535.";
	public const string SessionIDManager_uninit="SessionIDManager is not initialized. Call Initialize() method first.";
	public const string SessionIDManager_InitializeRequest_not_called="ISessionIDManager.InitializeRequest has not been called for this request yet. In each request, please first call ISessionIDManager.InitializeRequest before calling other methods.";

	public const string Cant_save_session_id_because_response_was_flushed="Session state has created a session id, but cannot save it because the response was already flushed by the application.";
	public const string Cant_save_session_id_because_id_is_invalid="Cannot save the session id because it is invalid.  Session ID="{0}";

	public const string Cant_serialize_session_state="Unable to serialize the session state. In 'StateServer' and 'SQLServer' mode, ASP.NET will serialize the session state objects, and as a result non-serializable objects or MarshalByRef objects are not permitted. The same restriction applies if similar serialization is done by the custom session state store in 'Custom' mode.";
	public const string Null_value_for_SessionStateItemCollection="The SessionStateStoreData returned by ISessionStateStore has a null value for Items.";
	//Invalid_child_node="Invalid child node is found in <sessionState>.
	public const string Session_id_too_long="The session ID is longer than the maximum limit of {0} characters. Session ID="{1}";
	public const string Need_v2_SQL_Server="Unable to use SQL Server because either ASP.NET version 2.0 Session State is not installed on the SQL server, or ASP.NET does not have permission to run the dbo.TempGetVersion stored procedure. If the ASP.NET Session State schema has not been installed, please install ASP.NET Session State SQL Server version 2.0 or above. If the schema has been installed, please grant execute permission on the dbo.TempGetVersion stored procedure to either the ASP.NET application pool identity, or the Sql Server user specified in the sqlConnectionString attribute.";
	public const string Need_v2_SQL_Server_partition_resolver="Unable to use SQL Server because either ASP.NET version 2.0 Session State is not installed on the SQL server, or ASP.NET does not have permission to run the dbo.TempGetVersion stored procedure. If the ASP.NET Session State schema has not been installed, please install ASP.NET Session State SQL Server version 2.0 or above. If the schema has been installed, please grant execute permission on the dbo.TempGetVersion stored procedure to either the ASP.NET application pool identity, or the Sql Server user specified in the sqlConnectionString attribute. The connection string (server="'{1}', database="'{2}') was returned by an instance of the IPartitionResolver type '{0}'.";
	public const string Cant_have_multiple_session_module="Another component has already added an HttpSessionState to the context. Please make sure only one session state module should be registered.";
	public const string Missing_session_custom_provider="The custom session state store provider '{0}' is not found.";
	public const string Invalid_session_custom_provider="The custom session state store provider name '{0}' is invalid.";
	public const string Invalid_session_state="The session state information is invalid and might be corrupted.";
	public const string Invalid_cache_based_session_timeout="For InProc and StateServer modes, the session timeout value cannot be larger than one year.";
	public const string Cant_use_partition_resolve="Cannot use 'partitionResolver' unless the mode is 'StateServer' or 'SQLServer'.";

	// Cross Page Posting

	public const string Previous_Page_Not_Authorized="The current user is not allowed to access the previous page.";

	// Custom errors

	//Customerrors_invalid_statuscode="The 'statusCode' is invalid. It must be between 100 and 999.

	// Util


	//Could_not_create_object="Could not create '{0}' object.

	public const string Empty_path_has_no_directory="Empty path has no directory.";
	public const string Path_must_be_rooted="The virtual path '{0}' is not rooted.";
	public const string Cannot_exit_up_top_directory="Cannot use a leading .. to exit above the top directory.";
	public const string Physical_path_not_allowed="'{0}' is a physical path, but a virtual path was expected.";
	public const string Invalid_vpath="'{0}' is not a valid virtual path.";
	public const string Cannot_access_AspCompat="Cannot access ASP compatibility mode.";
	public const string Apartment_component_not_allowed="The component '{0}' cannot be created.  Apartment threaded components can only be created on pages with an <%@ Page aspcompat="true %> page directive.";
	public const string Error_onpagestart="An error was encountered while calling OnStartPage in ASP compatibility mode.";
	public const string Cannot_execute_transacted_code="Cannot execute transacted code.";

	public const string Cannot_post_workitem="Cannot post work item to thread pool.";
	public const string Cannot_call_ISAPI_functions="Hosting platform does not support ISAPI functions.";
	public const string Bad_attachment="Invalid mail attachment '{0}'.";
	public const string Wrong_SimpleWorkerRequest="Invalid use of SimpleWorkerRequest constructor. Application path cannot be overridden in this context. Please use SimpleWorkerRequest constructor that does not override the application path.";
	public const string Atio2BadString="Unable to convert two characters in the string '{0}' to a number starting at offset {1}.";
	public const string MakeMonthBadString="Unable to convert characters in the string '{0}' to a month starting at offset {1}.";
	public const string UtilParseDateTimeBad="'{0}' was not of the correct format. Expected a string to be of the form 'Thursday, 10-Jun-93 01:29:59 GMT', 'Thu, 10 Jan 1993 01:29:59 GMT', or 'Wed Jun 09 01:29:59 1993 GMT'.";

	// Web Forms

	// Mail
	public const string SmtpMail_not_supported_on_Win7_and_higher="System.Web.Mail.SmtpMail is not supported on this version of Windows.  The recommended alternative is System.Net.Mail.SmtpClient.";

	// Build Manager
	public const string Illegal_special_dir="The file '{0}' is in the special directory '{1}', which is not allowed.";
	public const string Precomp_stub_file="This is a marker file generated by the precompilation tool, and should not be deleted!";
	public const string Already_precomp="This application is already precompiled.";
	public const string Cant_delete_dir="The target directory could not be deleted. Please delete it manually, or choose a different target.";
	public const string Dir_not_empty="The target directory is not empty. Please delete it manually, or choose a different target.";
	public const string Dir_not_empty_not_precomp="The target directory is not empty, and does not appear to contain a previously compiled application. Please delete it manually, or choose a different target.";
	public const string Cant_update_precompiled_app="The file '{0}' has not been pre-compiled, and cannot be requested.";
	public const string Too_early_for_webfile="The file '{0}' cannot be processed because the code directory has not yet been built.";
	public const string Bar_dir_in_precompiled_app="The directory '{0}' is not allowed because the application is precompiled.";
	public const string Assembly_already_loaded="The assembly '{0}' is already loaded in another appdomain. Setting <deployment retail=""true" /> in machine.config can help solve this issue.";
	public const string Success_precompile="The application was successfully precompiled.";
	public const string Profile_not_precomped="This application was precompiled with personalization turned off, but it appears to have been turned on after the precompilation, which is not supported.";
	public const string Both_culture_and_language="The file '{0}' cannot specify both a language and a culture.";
	public const string Inconsistent_language="The files '{0}' and '{1}' use a different language, which is not allowed since they need to be compiled together.";
	public const string GetGeneratedSourceFile_Directory_Only="The virtual path '{0}' does not point to a directory; only existing directories are allowed.";
	public const string Duplicate_appinitialize="The AppInitialize method is defined both in '{0}' and in '{1}'.";
	public const string Virtual_codedir="The path '{0}' maps to a directory outside this application, which is not supported.";
	public const string Unknown_buildprovider_extension="There is no build provider registered for the extension '{0}'. You can register one in the <compilation><buildProviders> section in machine.config or web.config. Make sure is has a BuildProviderAppliesToAttribute attribute which includes the value '{1}' or 'All'.";
	public const string Directory_progress="Building directory '{0}'.";
	public const string Bad_Base_Class_In_Code_File="Make sure that the class defined in this code file matches the 'inherits' attribute, and that it extends the correct base class (e.g. Page or UserControl).";
	public const string Reference_assemblies_not_found="Reference assemblies for target .NET Framework version not found; please ensure they are installed, or select a valid target version.";
	public const string Higher_dependencies="The following assembly has dependencies on a version of the .NET Framework that is higher than the target and might not load correctly during runtime causing a failure: {0}. The dependencies are: {1}. You should either ensure that the dependent assembly is correct for the target framework, or ensure that the target framework you are addressing is that of the dependent assembly.";
	public const string Invalid_target_framework_version="The value for the {0} attribute is invalid: '{1}'. Error: {2}.";
	public const string Invalid_lower_target_version="The '{0}' attribute in the <compilation> element of the Web.config file is used only to target version 4.0 and later of the .NET Framework (for example, '<compilation {0}=""4.0">'). If you are compiling this Web application for a version of the .NET Framework earlier than 4.0, remove the '{0}' attribute from the <compilation> element of the Web.config file.";
	public const string Invalid_higher_target_version="The '{0}' attribute in the <compilation> element of the Web.config file is used only to target version 4.0 and later of the .NET Framework (for example, '<compilation {0}=""4.0">'). The '{0}' attribute currently references a version that is later than the installed version of the .NET Framework. Specify a valid target version of the .NET Framework, or install the required version of the .NET Framework.";
	public const string Compiler_version_20_35_required="In the <compilation> section of the Web.config file, the value for the 'compilerVersion' attribute in the provider options must be 'v2.0' if you are targeting version 2.0 or 3.0 of the .NET Framework, or must be 'v3.5' if you are targeting version 3.5 of the .NET Framework. If you are compiling this Web application for version 4.0 or later of the .NET Framework, the '{0}' attribute is required in the <compilation> element of the Web.config file instead (for example, '<compilation {0}=""4.0">').";
	public const string Compiler_version_40_required="The value for the 'compilerVersion' attribute in the provider options must be 'v4.0' or later if you are compiling for version 4.0 or later of the .NET Framework. To compile this Web application for version 3.5 or earlier of the .NET Framework, remove the '{0}' attribute from the <compilation> element of the Web.config file.";
	public const string Assembly_not_found_in_profile="The following assembly could not be resolved: '{0}'. The assembly is excluded from the target framework profile{1}. If this reference is required by your code, you may get compilation errors. Please either remove this reference, or ensure that the target framework profile you are addressing contains the assembly.";
	public const string Downlevel_requires_35="The <compilation> element of the Web.config file does not have a 'targetFramework' attribute. Therefore ASP.NET assumes that the Web application targets the .NET Framework version 3.5 or earlier, but ASP.NET could not find files that are installed with the .NET Framework version 3.5 that it needs to compile. If you are compiling this Web application for version 3.5 or earlier of the .NET Framework, make sure that version 3.5 of the .NET Framework is installed. If you are compiling this Web application for version 4 or later of the .NET Framework, add the 'targetFramework' attribute to the <compilation> element of the Web.config file (for example, '<compilation targetFramework=""4.0">').";
	public const string Invalid_PreApplicationStartMethodAttribute_value="The method specified by the PreApplicationStartMethodAttribute on assembly '{0}' cannot be resolved. Type: '{1}', MethodName: '{2}'. Verify that the type is public and the method is public and static (Shared in Visual Basic).";
	public const string Method_can_only_be_called_during_pre_start_init="This method can only be called during the application's pre-start initialization phase. Use PreApplicationStartMethodAttribute to declare a method that will be invoked in that phase.";
	public const string Method_cannot_be_called_during_pre_start_init="This method cannot be called during the application's pre-start initialization phase.";
	public const string Pre_application_start_init_method_threw_exception="The pre-application start initialization method {0} on type {1} threw an exception with the following error message: {2}.";

	// Web Forms
	public const string Cant_use_default_items_and_filtered_collection="You cannot use {0}'s default collection '{1}' without the property tags when using a filtered version of the same collection.";
	public const string Children_not_supported_on_not_controls="Child objects are not supported for objects that are not controls.";
	public const string Code_not_supported_on_not_controls="Code blocks are not supported in this context.";
	public const string Code_not_allowed="Code blocks are not allowed in this file.";
	public const string Compilmode_not_allowed="The compilation mode cannot be set to 'Never', because an earlier construct in the page requires compilation.";
	public const string Include_not_allowed="The include file '{0}' is not allowed in this page.";
	public const string Attrib_not_allowed="The attribute '{0}' is not allowed in this page.";
	public const string Directive_not_allowed="The directive '{0}' is not allowed in this page.";
	public const string Event_not_allowed="The event handler '{0}' is not allowed in this page.";
	public const string Literal_content_not_allowed="Literal content ('{1}') is not allowed within a '{0}'.";
	public const string Literal_content_not_match_property="Content ('{1}') does not match any properties within a '{0}', make sure it is well-formed.";
	public const string Too_many_controls="This page allows a limit of {0} controls, and that limit has been exceeded.";
	public const string Too_many_dependencies="The page '{0}' allows a limit of {1} dependencies (direct or indirect), and that limit has been exceeded.";
	public const string Too_many_direct_dependencies="The page '{0}' allows a limit of {1} direct dependencies, and that limit has been exceeded.";
	public const string Invalid_type="Could not load type '{0}'.";
	public const string Assembly_not_compiled="Could not load the assembly '{0}'. Make sure that it is compiled before accessing the page.";
	public const string Not_a_src_file="'{0}' is not a valid source file.";
	public const string Ambiguous_type="The type '{0}' is ambiguous: it could come from assembly '{1}' or from assembly '{2}'. Please specify the assembly explicitly in the type name.";
	public const string Unsupported_filename="The file name '{0}' is not supported.";
	public const string Cannot_convert_from_to="Cannot convert from '{0}' to '{1}'.";
	public const string Object_tag_must_have_id="An object tag must have an ID.";
	public const string Invalid_scope="'{0}' is not a valid object scope.";
	public const string Invalid_progid="Cannot load type with ProgID '{0}'.";
	public const string Invalid_clsid="Cannot load type with CLASSID '{0}'.";
	public const string Object_tag_must_have_class_classid_or_progid="An object tag must contain a Class, ClassID or ProgID attribute.";
	public const string Session_not_enabled="Session state can only be used when enableSessionState is set to true, either in a configuration file or in the Page directive. Please also make sure that System.Web.SessionStateModule or a custom session state module is included in the <configuration>\\<system.web>\\<httpModules> section in the application configuration.";
	public const string Page_ControlState_ControlCannotBeNull="Cannot register a null control reference to require control state.";
	public const string Page_theme_not_found="Theme '{0}' cannot be found in the application or global theme directories.";
	public const string Page_theme_invalid_name="'{0}' is not a valid theme name.";
	public const string Page_theme_default_theme_already_defined="Type {0} already has a default theme defined.";
	public const string Page_theme_skinID_already_defined="SkinId '{0}' is already used by another control skin of the same type.";
	//Page_theme_skinID_not_found="SkinId '{0}' cannot be found for control of type {1}.
	public const string Page_theme_requires_page_header="Using themed css files requires a header control on the page. (e.g. <head runat=""server" />).";
	public const string Page_theme_only_controls_allowed="This object cannot be themed. Only controls of type System.Web.UI.Control are allowed at the top-level of a skin file.";
	public const string Page_theme_skin_file="skin file";
	public const string Page_Title_Requires_Head="Using the Title property of Page requires a header control on the page. (e.g. <head runat=""server" />).";
	public const string Page_Description_Requires_Head="Using the Description property of Page requires a header control on the page. (e.g. <head runat=""server" />).";
	public const string Page_Keywords_Requires_Head="Using the Keywords property of Page requires a header control on the page. (e.g. <head runat=""server" />).";
	public const string DataBoundLiterals_cant_bind="A call to Bind must be assigned to a property of a control inside a template.";
	public const string TwoWayBinding_requires_ID="The {0} control with a two-way databinding to field {1} must have an ID.";
	public const string NoCompileBinding_requires_ID="The {0} control with a databinding to field {1} must have an ID when the page's CompilationMode is Never.";
	public const string BadlyFormattedBind="A call to Bind was not well formatted.  Please refer to documentation for the correct parameters to Bind.";
	public const string BadlyFormattedBindItem="Invalid code syntax for BindItem.";
	public const string Property_readonly="The '{0}' property is read-only and cannot be set.";
	public const string Property_theme_disabled="The '{0}' property of a control type {1} cannot be applied through a control skin.";
	public const string Type_theme_disabled="The control type '{0}' cannot be themed.";
	public const string Collection_readonly_Codeblocks="The Controls collection cannot be modified because the control contains code blocks (i.e. <% ... %>).";
	public const string Parent_collections_readonly="The control collection cannot be modified during DataBind, Init, Load, PreRender or Unload phases.";
	public const string Property_Not_Persistable="The '{0}' property cannot be set declaratively.";
	public const string Property_Not_Supported="The '{0}' property is not supported by '{1}' control.";
	public const string Property_Not_ClsCompliant="The '{0}' property of '{1}' has type '{2}', which is not CLS-compliant.";
	public const string Property_Set_Not_Supported="Setting the {0} property of {1} is not supported.";
	public const string ControlBuilder_InvalidLocalizeValue="'{0}' is not a valid value for the meta:localize attribute. Only 'true' and 'false' are supported.";
	public const string meta_localize_error="The meta:resourcekey attribute cannot be used on a tag with meta:localize="'false'.";
	public const string meta_reskey_notallowed="The '{0}' tag cannot have a meta:resourcekey attribute.";
	public const string meta_localize_notallowed="The '{0}' tag cannot have a meta:localize attribute.";
	public const string Invalid_enum_value="'{0}' is not a valid value for attribute '{1}'. It must be of enum type '{2}'.";
	public const string Type_not_creatable_from_string="Cannot create an object of type '{0}' from its string representation '{1}' for the '{2}' property.";
	public const string Invalid_collection_item_type="{0} must have items of type '{1}'. '{2}' is of type '{3}'.";
	public const string Invalid_template_container="Template property '{0}' has a TemplateContainer attribute set to '{1}', but that type does not implement INamingContainer.";
	public const string Event_handler_cant_be_empty="The {0} event handler cannot be an empty string.";
	public const string Events_cant_be_filtered="The filter '{0}' cannot be applied to the attribute '{1}' because it is an event handler.";
	public const string Type_doesnt_have_property="Type '{0}' does not have a public property named '{1}'.";
	public const string Property_doesnt_have_property="Property '{0}' does not have a property named '{1}'.";
	//MasterPage_Multiple_content_filter="Multiple contents applied to {0} using filter {1}.
	public const string MasterPage_Multiple_content="Multiple contents applied to {0}.";
	//MasterPage_doesnt_have_property="Master page type '{0}' does not have property named '{1}'.
	public const string MasterPage_doesnt_have_contentplaceholder="Cannot find ContentPlaceHolder '{0}' in the master page '{1}', verify content control's ContentPlaceHolderID attribute in the content page.";
	public const string MasterPage_MasterPageFile="Gets and sets the masterPageFile used by this page.";
	public const string MasterPage_MasterPage="The MasterPage of this Page.";
	public const string MasterPage_Circular_Master_Not_Allowed="Circular MasterPageFile references '{0}' are not allowed.";
	public const string MasterPage_Cannot_ApplyTo_ReadOnly_Collection="MasterPage cannot be applied to this page because the control collection is read-only. If the page contains code blocks, make sure they are placed inside content controls (i.e. <asp:Content runat="server />)";
	public const string Only_Content_supported_on_content_page="Only Content controls are allowed directly in a content page that contains Content controls.";
	public const string Content_allowed_in_top_level_only="Content controls have to be top-level controls in a content page or a nested master page that references a master page.";
	public const string Content_only_allowed_in_content_page="Content controls are allowed only in content page that references a master page.";
	public const string Content_only_one_contentPlaceHolderID_allowed="Only one ContentPlaceHolderID attribute is allowed.";
	public const string Invalid_master_base="The file '{0}' is not a valid master page.";
	public const string Invalid_typeless_reference="The file '{0}' is not a valid here because it doesn't expose a type.";
	public const string Bad_masterPage_ext="Master page source files must have a .master file extension.";
	public const string Illegal_Device="The '{0}' attribute does not support the use of device filters.";
	public const string Illegal_Resource_Builder="The '{0}' attribute does not support the use of expression builders.";
	public const string Too_many_filters="The string '{0}' contains too many device filters. There can be only one.";
	public const string Device_unsupported_in_directive="The '{0}' directive does not support the use of device filters on its attributes.";
	public const string Cannot_add_value_not_collection="'{0}' could not be added to the collection. Details: {1}";
	public const string ControlBuilder_CollectionHasNoAddMethod="The collection '{0}' does not have an Add() method.";
	public const string Cannot_set_property="'{0}' could not be set on property '{1}'.";
	public const string Cannot_set_recursive_skin="Control '{0}' cannot be declared in a template inside a control skin of the same type with identical skinID.";
	public const string Cannot_evaluate_expression="Cannot have the expression '{0}' that does not support evaluate in a non-compiled page.";
	public const string Cannot_init="'{0}' could not be initialized. Details: {1}";
	public const string Unexpected_Directory="'{0}' is a directory, not a file.";
	public const string Circular_include="Circular file references are not allowed.";
	public const string Unexpected_eof_looking_for_tag="Unexpected end of file looking for </{0}> tag.";
	public const string Invalid_app_file_content="The content in the application file is not valid.";
	public const string Invalid_use_of_config_uc="The page '{0}' cannot use the user control '{1}', because it is registered in web.config and lives in the same directory as the page.";
	public const string Page_scope_in_global_asax="The Page scope is not valid in global.asax.";
	public const string App_session_only_valid_in_global_asax="The Application and Session scopes are valid only in the global.asax file.";
	public const string Multiple_forms_not_allowed="A page can have only one server-side Form tag.";
	public const string Postback_ctrl_not_found="An error has occurred because a control with id '{0}' could not be located or a different control is assigned to the same ID after postback. If the ID is not assigned, explicitly set the ID property of controls that raise postback events to avoid this error.";
	public const string Ctrl_not_data_handler="Page.RegisterRequiresPostBack can only be called on controls that implement IPostBackDataHandler.";
	public const string Transfer_not_allowed_in_callback="Server.Transfer cannot be called in a Page callback.";
	public const string Redirect_not_allowed_in_callback="Response.Redirect cannot be called in a Page callback.";
	public const string Script_tag_without_src_must_have_content="A script tag without a src attribute must have content.";
	public const string Unknown_server_tag="Unknown server tag '{0}'.";
	public const string Ambiguous_server_tag="The server tag '{0}' is ambiguous. Please modify the associated registration that is causing ambiguity and pick a new tag prefix.";
	public const string Invalid_type_for_input_tag="'{0}' is not a valid type for an input tag.";
	public const string Control_type_not_allowed="The control type '{0}' is not allowed on this page.";
	public const string Base_type_not_allowed="The base type '{0}' is not allowed for this page.";
	public const string Reference_not_allowed="The referenced file '{0}' is not allowed on this page.";
	public const string Id_already_used="The ID '{0}' is already used by another control.";
	public const string Duplicate_id_used="Multiple controls with the same ID '{0}' were found. {1} requires that controls have unique IDs.";
	public const string Only_one_directive_allowed="There can be only one '{0}' directive.";
	public const string Invalid_res_expr="'{0}' is not a valid expression string. It needs to use the following syntax: [className,] resourceKey.";
	public const string Res_not_found="The resource object with key '{0}' was not found.";
	public const string Res_not_found_with_class_and_key="The resource object with classname '{0}' and key '{1}' was not found.";
	public const string Invalid_cache_settings_location="The CacheSettings Location value is invalid.";
	public const string Registered_async_tasks_remain="There are registered asynchronous tasks that were never executed during the page processing.";
	public const string Async_tasks_wrong_thread="Cannot execute asynchronous tasks in the context of the current thread.";
	public const string Async_task_timed_out="An asynchronous operation exceeded the page timeout.";
	public const string ClientScriptManager_RegisterForEventValidation_Too_Early="RegisterForEventValidation can only be called during Render();";
	public const string ClientScriptManager_InvalidPostBackArgument="Invalid postback or callback argument.  Event validation is enabled using <pages enableEventValidation=""true"/> in configuration or <%@ Page EnableEventValidation=""true" %> in a page.  For security purposes, this feature verifies that arguments to postback or callback events originate from the server control that originally rendered them.  If the data is valid and expected, use the ClientScriptManager.RegisterForEventValidation method in order to register the postback or callback data for validation.";
	public const string ClientScriptManager_JqueryNotRegistered="WebForms UnobtrusiveValidationMode requires a ScriptResourceMapping for 'jquery'. Please add a ScriptResourceMapping named jquery(case-sensitive).";

	public const string DesignTimeTemplateParser_ErrorParsingTheme="There was an error parsing the theme:";
	public const string Duplicate_registered_tag="The '{0}' tag has already been registered.";
	public const string Empty_attribute="The '{0}' attribute cannot be an empty string.";
	public const string Space_attribute="The '{0}' attribute cannot contain spaces.";
	public const string Empty_expression="The expression in a <%=" %> or <%# %> block cannot be an empty string.";
	public const string ControlBuilder_DatabindingRequiresEvent="Databinding expressions are only supported on objects that have a DataBinding event. {0} does not have a DataBinding event.";
	public const string ControlBuilder_TwoWayBindingNonProperty="Two-way binding is only supported for properties. '{0}' is not a valid property on '{1}'";
	public const string ControlBuilder_CannotHaveMultipleBoundEntries="Cannot have more than one binding on property '{0}' on '{1}'. Ensure that this property is not bound through an implicit expression, for example, using meta:resourcekey.";
	public const string ControlBuilder_ExpressionsNotAllowedInThemes="Expressions are not allowed in skin files.";
	public const string FilteredAttributeDictionary_ArgumentMustBeString="The argument must be a string.";
	public const string HotSpotCollection_InvalidType="Object is not a HotSpot.";
	public const string HotSpotCollection_InvalidTypeIndex="Type index is out of bounds.";
	public const string Invalid_attribute_value="'{0}' is not a valid value for attribute '{1}'.";
	public const string Invalid_boolean_attribute="The '{0}' attribute must be set to 'true' or 'false'.";
	public const string Invalid_integer_attribute="The '{0}' attribute must be an integer value.";
	public const string Invalid_nonnegative_integer_attribute="The '{0}' attribute must be a non-negative integer.";
	public const string Invalid_positive_integer_attribute="The '{0}' attribute must be set to a positive integer value.";
	public const string Invalid_non_zero_hexadecimal_attribute="The '{0}' attribute must be set to a non-zero hexadecimal value.";
	public const string Invalid_hash_algorithm_type="The '{0}' hash algorithm type could not be instantiated.";
	//Invalid_integer_not_in_range_attribute="The '{0}' attribute must be within the range from {1} to {2}
	public const string Invalid_enum_attribute="The '{0}' attribute must be one of the following values: {1}.";
	//Invalid_timespan_attribute="The '{0}' attribute must be in the form [[hh:]mm:]ss or 'Infinite'
	public const string Invalid_culture_attribute="The 'Culture' attribute must be set to a non-neutral culture.  Try one of the following: {0}.";
	public const string Invalid_temp_directory="The '{0}' attribute must be set to a valid absolute path.";
	public const string Invalid_reference_directive="The Reference directive must have a VirtualPath attribute, and no other attributes.";
	public const string Invalid_reference_directive_attrib="The file '{0}' is not of a type that can be used here.";
	public const string Invalid_typeNameOrVirtualPath_directive="The '{0}' directive must have exactly one attribute: TypeName or VirtualPath";
	public const string Invalid_tagprefix_entry="Invalid or missing attributes found in the tagPrefix entry. For user control, you must also specify 'tagName' and 'src'. For custom control, you must also specify 'namespace', and optionally 'assembly'.";
	public const string Mapped_type_must_inherit="The specified type '{0}' used for mapping must inherit from the original type '{1}'.";
	//Time_must_be_at_least_something="The '{0}' attribute must be set to at least '{1}' minute(s).
	//Invalid_non_zero_timespan_attribute="The '{0}' attribute must be set to a non-zero time span value in the form [[hh:]mm:]ss or 'Infinite'.

	public const string Missing_required_attribute="The '{0}' attribute must be specified on the '{1}' tag.";
	public const string Missing_required_attributes="The '{0}' or '{1}' attribute must be specified on the '{1}' tag.";
	public const string Attr_not_supported_in_directive="The '{0}' attribute is not supported by the '{1}' directive.";
	public const string Attr_not_supported_in_ucdirective="The '{0}' attribute is not supported by the '{1}' directive in a user control.";
	public const string Attr_not_supported_in_pagedirective="The '{0}' attribute is not supported by the '{1}' directive in a page.";
	public const string Invalid_attr="The '{0}' attribute is not supported on this directive when a '{1}' attribute is present.";
	public const string Attrib_parse_error="Error parsing attribute '{0}': {1}";
	public const string Missing_attr="The directive is missing a '{0}' attribute.";
	public const string Missing_output_cache_attr="The directive or the configuration settings profile must specify the '{0}' attribute.";
	public const string Missing_varybyparam_attr="The directive is missing a 'VaryByParam' attribute, which should be set to "none", "*", or a semicolon separated list of values.";
	public const string Missing_directive="The page must have a <%@ {0} class=""MyNamespace.MyClass" ... %> directive.";
	public const string Unknown_directive="The directive '{0}' is unknown.";
	public const string Malformed_server_tag="The server tag is not well formed.";
	public const string Malformed_server_block="The server block is not well formed.";
	public const string Server_tags_cant_contain_percent_constructs="Server tags cannot contain <% ... %> constructs.";
	public const string Include_not_allowed_in_server_script_tag="Server includes are not allowed in server script tags.";
	public const string Incompatible_with_get_bufferless_input_stream="This method or property is not supported after HttpRequest.GetBufferlessInputStream has been invoked.";
	public const string Incompatible_with_get_buffered_input_stream="This method or property is not supported after HttpRequest.GetBufferedInputStream has been invoked.";
	public const string Incompatible_with_input_stream="This method or property is not supported after HttpRequest.Form, Files, InputStream, or BinaryRead has been invoked.";
	public const string Invalid_operation_with_get_buffered_input_stream="Either BinaryRead, Form, Files, or InputStream was accessed before the internal storage was filled by the caller of HttpRequest.GetBufferedInputStream.";
	public const string Only_file_virtual_supported_on_server_include="Only file and virtual are valid attributes in server-side include tags.";
	public const string Runat_can_only_be_server="The Runat attribute must have the value Server.";
	public const string Invalid_identifier="'{0}' is not a valid identifier.";
	public const string Invalid_resourcekey="'{0}' is not a valid resource key.";
	public const string ControlBuilder_IDMustUseAttribute="The ID property of a control can only be set using the ID attribute in the tag and a simple value. Example: <asp:Button runat=""server" id=""Button1" />";
	public const string ControlBuilder_CannotHaveComplexString="The '{1}' property of '{0}' cannot be declared as an inner property, it must be declared as an attribute.";
	public const string ControlBuilder_ParseTimeDataNotAvailable="The ParseTimeData property can only be used during parsing.";
	public const string Duplicate_attr_in_directive="The directive contains duplicate '{0}' attributes.";
	public const string Duplicate_attr_in_tag="The tag contains duplicate '{0}' attributes.";
	//Duplicate_entry_in_control="The control contains duplicate '{0}' entries.
	public const string Non_existent_base_type="The base type '{0}' does not exist in the source file '{1}'.";
	public const string Invalid_type_to_inherit_from="'{0}' is not allowed here because it does not extend class '{1}'.";
	public const string Invalid_type_to_implement="'{0}' exists but is not an interface.";
	public const string Error_page_not_supported_when_buffering_off="Error page is not supported when buffering is disabled.";
	public const string Enablesessionstate_must_be_true_false_or_readonly="enableSessionState must be set to true, false or ReadOnly";
	public const string Attributes_mutually_exclusive="The '{0}' and '{1}' attributes are mutually exclusive.";
	public const string Async_and_aspcompat="Async attribute cannot be set to true when AspCompat mode is enabled.";
	public const string Async_and_transaction="Async attribute cannot be set to true when Transaction mode is enabled.";
	public const string Async_required="This operation requires the page to be asynchronous (the Async attribute must be set to true).";
	public const string Async_addhandler_too_late="This operation can only be performed prior to PreRenderComplete page event.";
	public const string Async_operation_disabled="Asynchronous operations are not allowed in this context. Page starting an asynchronous operation has to have the Async attribute set to true and an asynchronous operation can only be started on a page prior to PreRenderComplete event.";
	public const string Async_operation_pending="There is a pending asynchronous operation, and only one asynchronous operation can be pending concurrently.";
	public const string Async_null_asyncresult="IAsyncResult returned from Begin method is null.";
	public const string Async_operation_cannot_be_started="An asynchronous operation cannot be started at this time. Asynchronous operations may only be started within an asynchronous handler or module or during certain events in the Page lifecycle. If this exception occurred while executing a Page, ensure that the Page is marked <%@ Page Async="\"true\" %>. This exception may also indicate an attempt to call an \"async void\" method, which is generally unsupported within ASP.NET request processing. Instead, the asynchronous method should return a Task, and the caller should await it.";
	public const string Async_operation_cannot_be_pending="An asynchronous module or handler completed while an asynchronous operation was still pending.";
	public const string Server_execute_blocked_on_async_handler="HttpServerUtility.Execute blocked while waiting for an asynchronous operation to complete.";
	public const string Mixed_lang_not_supported="Cannot use '{0}' because another language has been specified earlier in this page (or was implied from a CodeFile attribute).";
	public const string Inconsistent_CodeFile_Language="The language of the code file is inconsistent with the language of the page.";
	public const string Codefile_without_inherits="The 'CodeFile' attribute cannot be used without an 'Inherits' attribute.";
	public const string CodeFileBaseClass_Without_Codefile="The 'CodeFileBaseClass' attribute cannot be used without a 'CodeFile' attribute.";
	public const string Invalid_lang="'{0}' is not a supported language.";
	public const string Invalid_lang_extension="'{0}' is not a valid language extension.";
	public const string Cant_use_nocompile_uc="The user control '{0}' is not compiled, and can only be used dynamically. To force it to be compiled, set compilationMode=""Always" in its @control directive.";
	public const string Invalid_CodeSubDirectory_Not_Exist="The code subdirectory '{0}' does not exist.";
	public const string Invalid_CodeSubDirectory="Invalid subdirectory '{0}'. Only subdirectories directly under the App_Code directory are allowed.";
	public const string Reserved_AssemblyName="'{0}' is a reserved assembly name, and cannot be used for a code subdirectory.";

	public const string Empty_extension="The file '{0}' must have an extension in order to be compiled.";
	public const string Base_class_field_with_type_different_from_type_of_control="The base class includes the field '{0}', but its type ({1}) is not compatible with the type of control ({2}).";
	public const string ControlSkin_cannot_contain_controls="Control skins cannot contain child controls.";
	public const string Inner_Content_not_literal="Cannot get inner content of {0} because the contents are not literal.";
	public const string Invalid_client_target="ClientTarget is set to an invalid alias '{0}'.  The <clientTarget> configuration section is used to define ClientTarget aliases.";
	public const string Empty_file_name="The file name cannot be an empty string.";
	public const string SetStyleSheetThemeCannotBeSet="The StyleSheetTheme property cannot be set, please override the property instead.";
	public const string PropertySetBeforePageEvent="The '{0}' property can only be set in or before the '{1}' event.";
	public const string PropertySetBeforeStyleSheetApplied="The '{0}' property cannot be changed dynamically if Page has a stylesheet theme. For dynamic controls, set the property before calling ApplyStyleSheetSkin().";
	public const string PropertySetBeforePreInitOrAddToControls="The '{0}' property can only be set in or before the Page_PreInit event for static controls. For dynamic controls, set the property before adding it to the Controls collection.";
	public const string PropertySetAfterFrameworkInitialize="The '{0}' property can only be set in the page directive or in the <pages> configuration section.";
	public const string StyleSheetAreadyAppliedOnControl="StyleSheetTheme is already applied on the control, it cannot be applied more than once.";
	public const string Control_CannotOwnSelf="A control cannot own itself.";
	public const string AdRotator_cant_open_file="The AdRotator {0} was unable to open the AdvertisementFile '{1}'.";
	public const string AdRotator_cant_open_file_no_permission="The AdRotator {0} could not find the AdvertisementFile or the file is invalid.";
	public const string AdRotator_parse_error="The AdRotator {0} was unable to parse the XML in the AdvertisementFile. {1}";
	public const string AdRotator_no_advertisements="The AdRotator {0} found no valid advertisements in the file '{1}'.";
	public const string AdRotator_only_one_datasource="Only one of AdvertisementFile, DataSource, or DataSourceID properties can be set on AdRotator '{0}'.";
	public const string AdRotator_invalid_integer_format="The value '{0}' of field '{1}' of an advertisement data has to be a valid string to be parsed by {2}.";
	public const string AdRotator_expect_records_with_advertisement_properties="The AdRotator '{0}' is expecting the data type of the first item in the collection from the DataSource property to have advertisement properties such as ImageUrl, NavigateUrl, etc..  The current data type of the item is '{1}'.";
	public const string Validator_control_blank="The ControlToValidate property of '{0}' cannot be blank.";
	public const string Validator_control_not_found="Unable to find control id '{0}' referenced by the '{1}' property of '{2}'.";
	public const string Validator_bad_compare_control="Control '{0}' cannot have the same value '{1}' for both ControlToValidate and ControlToCompare.";
	public const string Validator_bad_control_type="Control '{0}' referenced by the {1} property of '{2}' cannot be validated.";
	public const string Validator_value_bad_type="The value '{0}' of the {1} property of '{2}' cannot be converted to type '{3}'.";
	public const string Validator_range_overalap="The MaximumValue {0} cannot be less than the MinimumValue {1} of {2}.";
	public const string Validator_bad_regex="{0} is not a valid regular expression.";
	public const string ValSummary_error_message_1="Error message 1.";
	public const string ValSummary_error_message_2="Error message 2.";
	public const string ViewState_MissingViewStateField="Invalid viewstate: Missing field: {0}.";
	public const string ViewState_InvalidViewState="Invalid viewstate.";
	public const string ViewState_InvalidViewStatePlus="Invalid viewstate. {0}";
	public const string ClientDisconnected="The client disconnected.";
	public const string HttpBufferlessInputStream_ClientDisconnected="The client is disconnected because the underlying request has been completed.  There is no longer an HttpContext available.";
	public const string ViewState_ClientDisconnected="The client disconnected.";
	public const string ViewState_AuthenticationFailed="Validation of viewstate MAC failed. If this application is hosted by a Web Farm or cluster, ensure that <machineKey> configuration specifies the same validationKey and validation algorithm. AutoGenerate cannot be used in a cluster.\r\n\r\nSee http://go.microsoft.com/fwlink/?LinkID="314055 for more information.";
	public const string Control_does_not_allow_children="'{0}' does not allow child controls.";
	public const string DataBinder_Prop_Not_Found="DataBinding: '{0}' does not contain a property with the name '{1}'.";
	public const string DataBinder_Invalid_Indexed_Expr="DataBinding: '{0}' is not a valid indexed expression.";
	public const string DataBinder_No_Indexed_Accessor="DataBinding: '{0}' does not allow indexed access.";
	public const string XPathBinder_MustBeIXPathNavigable="XPath DataBinding: '{0}' must implement IXPathNavigable.";
	public const string XPathBinder_MustHaveXmlNodes="XPathBinder.Select can only be used with data sources that contain XmlNodes.";
	public const string Field_Not_Found="A field or property with the name '{0}' was not found on the selected data source.";
	public const string DataItem_Not_Found="A data item was not found in the container. The container must either implement IDataItemContainer, or have a property named DataItem.";
	public const string DataGrid_Missing_VirtualItemCount="AllowCustomPaging must be true and VirtualItemCount must be set for a DataGrid with ID '{0}' when AllowPaging is set to true and the selected data source does not implement ICollection.";
	public const string DataGrid_NoAutoGenColumns="DataGrid with id '{0}' could not automatically generate any columns from the selected data source.";
	public const string GridView_Missing_VirtualItemCount="GridView with id '{0}' must have a data source that either implements ICollection or can perform data source paging if AllowPaging is true.";
	public const string GridView_NoAutoGenFields="The data source for GridView with id '{0}' did not have any properties or attributes from which to generate columns.  Ensure that your data source has content.";
	public const string GridView_DataSourceReturnedNullView="The IDataSource that is the data source for GridView '{0}' returned a null view.  Check that the DataMember property value of GridView is valid.";
	public const string GridView_UnhandledEvent="The GridView '{0}' fired event {1} which wasn't handled.";
	public const string GridView_MustBeParented="A GridView with EnableSortingAndPagingCallbacks set to true must be parented to a naming container before Render is called.";
	public const string GridView_DataKeyNamesMustBeSpecified="Data keys must be specified on GridView '{0}' before the selected data keys can be retrieved.  Use the DataKeyNames property to specify data keys.";
	public const string GridView_PersistedSelectionRequiresDataKeysNames="DataKeyNames must be specified for persisted selection to work.";
	public const string DetailsView_NoAutoGenFields="DetailsView with id '{0}' did not have any properties or attributes from which to generate fields.  Ensure that your data source has content.";
	public const string DetailsView_UnhandledEvent="The DetailsView '{0}' fired event {1} which wasn't handled.";
	public const string DetailsView_DataSourceMustBeCollection="DetailsView with id '{0}' must have a data source that implements ICollection if AllowPaging is true.";
	public const string DetailsView_MustBeParented="A DetailsView with EnablePagingCallbacks set to true must be parented to a naming container before Render is called.";
	public const string FileUpload_AllowMultiple="Whether to enable multi-file uploads.";
	public const string FileUpload_StreamNotSeekable="The stream returned by FileContent does not support seeking, so FileBytes is not supported.";
	public const string FileUpload_StreamTooLong="The stream returned by FileContent is longer than Int32.MaxValue.  FileBytes supports only streams less than or equal to Int32.MaxValue.";
	public const string FileUpload_StreamLengthNotReached="The byte stream that represents the uploaded file appears to be incomplete.  Try the upload again.";
	public const string FormView_UnhandledEvent="The FormView '{0}' fired event {1} which wasn't handled.";
	public const string FormView_DataSourceMustBeCollection="DetailsView with id '{0}' must have a data source that implements ICollection if AllowPaging is true.";
	public const string DetailsViewFormView_ControlMustBeInEditMode="{0} '{1}' must be in edit mode to update a record.";
	public const string DetailsViewFormView_ControlMustBeInInsertMode="{0} '{1}' must be in insert mode to insert a new record.";
	public const string DataBoundControl_InvalidDataPropertyChange="Data properties on data control '{0}' such as DataSource, DataSourceID, and DataMember cannot be changed during the databinding phase of the control.";
	public const string DataBoundControl_NullView="The data source retrieved by '{0}' returned a null DataSourceView.";
	public const string DataBoundControl_InvalidDataSourceType="Data source is an invalid type.  It must be either an IListSource, IEnumerable, or IDataSource.";
	public const string DataBoundControl_DataSourceDoesntSupportPaging="The data source '{0}' does not support server-side paging and it returned non-ICollection data.  See your data source documentation to enable paging.";
	public const string DataBoundControl_CallingDataMethods="Occurs before model methods are invoked for data operations. Handle this event if the model methods are defined on a custom type other than the code behind file.";
	public const string DataBoundControl_NeedICollectionOrTotalRowCount="If a data source does not return ICollection and cannot return the total row count, it cannot be used by the {0} to implement server-side paging.";
	public const string DataBoundControlHelper_NoNamingContainer="The {0} control '{1}' does not have a naming container.  Ensure that the control is added to the page before calling DataBind.";
	public const string HierarchicalDataBoundControl_InvalidDataSource="HierarchicalDataBoundControl only accepts data sources that implement IHierarchicalDataSource or IHierarchicalEnumerable.";
	public const string DataBoundControl_OnCreatingModelDataSource="Raised before the data bound control is data binding using data methods.";
	public const string HierarchicalDataControl_ViewNotFound="The view that hierarchical data bound control '{0}' requested could not be found.";
	public const string HierarchicalDataControl_DataSourceIDMustBeHierarchicalDataControl="The DataSourceID of '{0}' must be the ID of a control of type IHierarchicalDataSource.  '{1}' is not an IHierarchicalDataSource.";
	public const string HierarchicalDataControl_DataSourceDoesntExist="The DataSourceID of '{0}' must be the ID of a control of type IHierarchicalDataSource.  A control with ID '{1}' could not be found.";
	public const string DataControl_ViewNotFound="The view that data bound control '{0}' requested could not be found. Check that the DataMember property is valid.";
	public const string DataControl_DataSourceIDMustBeDataControl="The DataSourceID of '{0}' must be the ID of a control of type IDataSource.  '{1}' is not an IDataSource.";
	public const string DataControl_DataSourceDoesntExist="The DataSourceID of '{0}' must be the ID of a control of type IDataSource.  A control with ID '{1}' could not be found.";
	public const string DataControl_MultipleDataSources="Both DataSource and DataSourceID are defined on '{0}'.  Remove one definition.";
	public const string DataControl_ItemType_MultipleDataSources="DataSource or DataSourceID cannot be defined on '{0}' when it uses model binding.";
	public const string DataControlField_NoContainer="A DataControlField must be within an INamingContainer.";
	public const string DataControlField_CallbacksNotSupported="Callbacks are not supported on this data control field.  Turn callbacks off on '{0}'.";
	public const string DataControlFieldCollection_InvalidType="Object is not a DataControlField.";
	public const string DataControlFieldCollection_InvalidTypeIndex="Type index is out of bounds.";
	public const string BoundField_WrongControlType="BoundField {0} contains a control that isn't a TextBox.  Override OnDataBindField to inherit from BoundField and add different controls.";
	public const string CheckBoxField_WrongControlType="CheckBoxField '{0}' contains a control that isn't a CheckBox.  Override OnDataBindField to inherit from CheckBoxField and add different controls.";
	public const string CheckBoxField_CouldntParseAsBoolean="The data in the CheckBoxField '{0}' could not be parsed as a boolean value.  Try using a BoundField instead.";
	public const string CheckBoxField_NotSupported="The property {0} is not supported on CheckBoxField.";
	public const string CommandField_CallbacksNotSupported="Callbacks are not supported on CommandField when the select button is enabled because other controls on your page that are dependent on the selected value of '{0}' for their rendering will not update in a callback.  Turn callbacks off on '{0}'.";
	public const string ImageField_WrongControlType="ImageField {0} contains a control that isn't a TextBox in edit mode, or an Image and a Label in read-only mode.  Override OnDataBindField to inherit from ImageField and add different controls.";
	public const string TemplateField_CallbacksNotSupported="Callbacks are not supported on TemplateField because some controls cannot update properly in a callback.  Turn callbacks off on '{0}'.";
	public const string PagedDataSource_Cannot_Get_Count="Cannot compute Count for a data source that does not implement ICollection.";
	public const string Cannot_Have_Children_Of_Type="'{0}' cannot have children of type '{1}'.";
	public const string Control_Cannot_Databind="'{0}' cannot contain a data binding expression.";
	public const string InnerHtml_not_supported="'{0}' does not support the InnerHtml property.";
	public const string InnerText_not_supported="'{0}' does not support the InnerText property.";
	public const string ListControl_SelectionOutOfRange="'{0}' has a {1} which is invalid because it does not exist in the list of items.";
	public const string ListControl_RenderWhenDataEmptyNotSupportedWithTableLayout="The RepeatLayout property on control '{0}' does not support Table layout when RenderWhenDataEmpty is enabled.";
	public const string ListControl_RenderWhenDataEmpty="Render the control's outer markup when not bound to data or data is empty.";
	public const string BulletedList_SelectionNotSupported="Setting the SelectedIndex or SelectedValue properties of BulletedList is not supported.";
	public const string BulletedList_TextNotSupported="Setting the Text property of BulletedList is not supported.";
	public const string CannotUseParentPostBackWhenValidating="A button that causes validation in {0} '{1}' is attempting to use the container {0} as the post back target.  The button should either turn off validation or use itself as the post back container.";
	public const string CannotSetValidationOnDataControlButtons="Setting CausesValidation on DataControlButtons is not supported.";
	public const string CannotSetValidationOnPagerButtons="Setting CausesValidation on DataControlPagerLinkButtons is not supported.";
	public const string Invalid_DataSource_Type="An invalid data source is being used for {0}. A valid data source must implement either IListSource or IEnumerable.";
	public const string Invalid_CurrentPageIndex="Invalid CurrentPageIndex value. It must be >=" 0 and < the PageCount.";
	public const string ListSource_Without_DataMembers="The IListSource does not contain any data sources.";
	public const string ListSource_Missing_DataMember="The IListSource does not contain a data source named '{0}'.  Check your DataMember value.";
	public const string Enumerator_MoveNext_Not_Called="You must call MoveNext on IEnumerator before accessing the Current property.";
	public const string Sample_Databound_Text="Databound";
	public const string Resource_problem="An error occurred while try to load the string resources ({0} failed with error {1}).";
	public const string Duplicate_Resource_File="The resource file '{0}' cannot be used, as it conflicts with another file with the same name.";
	public const string Property_Had_Malformed_Url="The '{0}' property had a malformed URL: {1}.";
	public const string TypeResService_Needed="The supplied IDesignerHost must provide an implementation of ITypeResolutionService.";
	public const string DataList_TemplateTableNotFound=" A Table control was not found in the template for '{0}' for an item of type 'ListItemType.{1}'.";
	public const string DataList_DataKeyFieldMustBeSpecified="Data keys must be specified on DataList '{0}' before the selected data key can be retrieved.  Use the DataKeyField property to specify data keys.";
	public const string DataList_LayoutNotSupported="DataList does not support the '{0}' layout.";
	public const string EnumAttributeInvalidString="'{0}' is not a valid value for the '{2}' attribute. '{2}' must be a single text (not numeric) value from the '{3}' enumeration.";
	public const string UnitParseNumericPart="The numeric part ('{1}') of '{0}' cannot be parsed as a numeric part of a {2} unit.";
	public const string UnitParseNoDigits="'{0}' cannot be parsed as a unit as there are no numeric values in it. Examples of valid unit strings are '1px' and '.5in'.";
	public const string IsValid_Cant_Be_Called="Page.IsValid cannot be called before validation has taken place. It should be queried in the event handler for a control that has CausesValidation="True and initiated the postback, or after a call to Page.Validate.";
	public const string Invalid_HtmlTextWriter="An instance of '{0}' could not be used as an HtmlTextWriter. Make sure the specified class can be instantiated, extends System.Web.UI.HtmlTextWriter, and implements a constructor with a single parameter of type System.IO.TextWriter.";
	public const string Form_Needs_Page="HtmlForm cannot render without a reference to the Page instance.  Make sure your form has been added to the control tree.";
	public const string InvalidDefaultAutoFieldGenerator="The field generator of type '{0}' can be used only with '{1}'.";

	public const string HtmlForm_OnlyIButtonControlCanBeDefaultButton="The DefaultButton of '{0}' must be the ID of a control of type IButtonControl.";
	public const string Head_Needs_Page="HtmlHead cannot render without a reference to the Page instance.  Make sure your head has been added to the control tree.";
	public const string HtmlHead_StyleAlreadyRegistered="You cannot register a style twice.";
	public const string HtmlHead_OnlyOneHeadAllowed="You can only have one <head runat=""server"> control on a page.";
	public const string HtmlHead_OnlyOneTitleAllowed="You can only have one <title> element within the <head> element.";
	public const string Style_RegisteredStylesAreReadOnly="Registered Styles are read-only.";
	public const string Style_InvalidBorderWidth="BorderWidth must be a non-negative number and cannot be a percentage.";
	public const string Style_InvalidWidth="Width must be non negative.";
	public const string Style_InvalidHeight="Height must be non negative.";
	public const string Cant_Multiselect_In_Single_Mode="Cannot have multiple items selected when the SelectionMode is Single.";
	public const string Cant_Multiselect="Cannot have multiple items selected in a {0}.";
	public const string HtmlSelect_Cant_Multiselect_In_Single_Mode="An HtmlSelect cannot have multiple items selected when Multiple is false.";
	public const string Controls_Cant_Change_Between_Posts="Failed to load viewstate.  The control tree into which viewstate is being loaded must match the control tree that was used to save viewstate during the previous request.  For example, when adding controls dynamically, the controls added during a post-back must match the type and position of the controls added during the initial request.";
	public const string Value_Set_Not_Supported="The value property on {0} is not settable.";

	public const string SiteMap_feature_disabled="This feature is currently disabled, please enable section {0} in the configuration file.";
	public const string SiteMapNode_readonly="SiteMapNode is readonly, property {0} cannot be modified.";
	public const string SiteMapNodeCollection_Invalid_Type="Invalid value of type {0} passed in, value must be of type SiteMapNode.";
	public const string SiteMapProvider_Circular_Provider="Circular Providers not allowed.";
	public const string SiteMapProvider_Invalid_RootNode="Root node defined in provider {0} is null, root node cannot be null.";
	public const string SiteMapProvider_cannot_remove_root_node="Root node cannot be removed from the providers, use RemoveProvider(string providerName) instead.";
	public const string XmlSiteMapProvider_cannot_add_node="SiteMapNode {0} cannot be found in current provider, only nodes in the same provider can be added.";
	public const string XmlSiteMapProvider_invalid_resource_key="Resource key {0} is not valid, it must contain a valid class name and key pair. For example, $resources:'className','key'";
	public const string XmlSiteMapProvider_resourceKey_cannot_be_empty="Resource key cannot be empty.";
	public const string XmlSiteMapProvider_cannot_find_provider="Provider {0} cannot be found inside XmlSiteMapProvider {1}.";
	//XmlSiteMapProvider_remove_node_without_provider="SiteMapNode {0} does not have a provider, cannot remove a node without a valid provider.
	public const string XmlSiteMapProvider_cannot_remove_node="SiteMapNode {0} does not exist in provider {1}, it must be removed from provider {2}.";
	public const string XmlSiteMapProvider_missing_siteMapFile="The {0} attribute must be specified on the XmlSiteMapProvider.";
	public const string XmlSiteMapProvider_Description="SiteMap provider which reads in .sitemap XML files.";
	public const string XmlSiteMapProvider_Not_Initialized="XmlSiteMapProvider is not initialized. Call Initialize() method first.";
	public const string XmlSiteMapProvider_Cannot_Be_Inited_Twice="XmlSiteMapProvider cannot be initialized twice.";
	public const string XmlSiteMapProvider_Top_Element_Must_Be_SiteMap="Top element must be siteMap.";
	public const string XmlSiteMapProvider_Only_One_SiteMapNode_Required_At_Top="Exactly one <siteMapNode> element is required directly inside the <siteMap> element.";
	public const string XmlSiteMapProvider_Only_SiteMapNode_Allowed="Only <siteMapNode> elements are allowed at this location.";
	public const string XmlSiteMapProvider_invalid_sitemapnode_returned="Provider {0} must return a valid sitemap node.";
	public const string XmlSiteMapProvider_invalid_GetRootNodeCore="GetRootNode is returning null from Provider {0}, this method must return a non-empty sitemap node.";
	public const string XmlSiteMapProvider_Error_loading_Config_file="The XML sitemap config file {0} could not be loaded.  {1}";
	public const string XmlSiteMapProvider_FileName_does_not_exist="The file {0} required by XmlSiteMapProvider does not exist.";
	public const string XmlSiteMapProvider_FileName_already_in_use="The sitemap config file {0} is already used by other nodes or providers.";
	//XmlSiteMapProvider_Invalid_SiteMapFile="XmlSiteMapProvider does not allow physical path {0}, use virtual path instead.
	public const string XmlSiteMapProvider_Invalid_Extension="The file {0} has an invalid extension, only .sitemap files are allowed in XmlSiteMapProvider.";
	public const string XmlSiteMapProvider_multiple_resource_definition="Cannot have more than one resource binding on attribute '{0}'. Ensure that this attribute is not bound through an implicit expression, for example, {0}=""$resources:key".";

	public const string UrlMappings_only_app_relative_url_allowed="The URL '{0}' is not valid. Only application relative URLs (~/url) are allowed.";
	//UrlMappings_url_already_defined="URL {0} is already defined for mappings.
	//UrlMappings_url_not_defined="Cannot remove undefined URL {0}.
	public const string FileName_does_not_exist="The file '{0}' does not exist.";
	public const string SiteMapProvider_Multiple_Providers_With_Identical_Name="Multiple providers with the same name '{0}' were found. SiteMap requires providers have unique names.";
	public const string XmlSiteMapProvider_Multiple_Nodes_With_Identical_Url="Multiple nodes with the same URL '{0}' were found. XmlSiteMapProvider requires that sitemap nodes have unique URLs.";
	public const string XmlSiteMapProvider_Multiple_Nodes_With_Identical_Key="Multiple nodes with the same key '{0}' were found. XmlSiteMapProvider requires that sitemap nodes have unique keys.";
	public const string Provider_Not_Found="Provider '{0}' was not found.";
	public const string Provider_does_not_support_policy_for_responses="When using a custom output cache provider like '{0}', only the following expiration policies and cache features are supported:  file dependencies, absolute expirations, static validation callbacks and static substitution callbacks.";
	public const string Provider_does_not_support_policy_for_fragments="When using a custom output cache provider like '{0}', only the following expiration policies and cache features are supported:  file dependencies and absolute expirations.";
	public const string GetOutputCacheProviderName_Invalid="HttpApplication.GetOutputCacheProviderName returned '{0}', but the provider was not found.";
	public const string OutputCacheExtensibility_CantSerializeDeserializeType="The provided parameter is not of a supported type for serialization and/or deserialization.";
	public const string Collection_readonly="Collection is read-only.";
	public const string ParameterCollection_NotParameter="Object is not a Parameter.";
	public const string ControlParameter_CouldNotFindControl="Could not find control '{0}' in ControlParameter '{1}'.";
	public const string ControlParameter_ControlIDNotSpecified="A ControlID must be specified in ControlParameter '{0}'.";
	public const string ControlParameter_PropertyNameNotSpecified="PropertyName must be set to a valid property name of the control named '{0}' in ControlParameter '{1}'.";
	public const string DataSourceCache_InvalidExpiryPolicy="Invalid DataSourceCacheExpiry.";
	public const string DataSourceCache_InvalidDuration="The duration must be non-negative.";
	public const string DataSourceCache_CacheMustBeEnabled="Cannot perform operation when cache is not enabled.";
	//DataSourceCache_StringEnabled="Enabled
	//DataSourceCache_StringNotEnabled="Not enabled
	public const string DataSourceView_NoPaging="The data source does not support server-side data paging.";
	public const string DataSourceView_NoSorting="The data source does not support sorting.";
	public const string DataSourceView_NoRowCount="The data source does not support retrieving the number of rows of data.";
	public const string AccessDataSource_Description="Connect to an Access database created with Microsoft Office.";
	public const string AccessDataSource_DisplayName="Access Database";
	public const string AccessDataSource_CannotSetConnectionString="The AccessDataSource ConnectionString property cannot be set, it is automatically generated.";
	public const string AccessDataSource_CannotSetProvider="The provider name cannot be set on AccessDataSource '{0}'.";
	public const string AccessDataSource_SqlCacheDependencyNotSupported="SQL cache dependencies are not supported on AccessDataSource '{0}'.";
	public const string AccessDataSource_DesignTimeRelativePathsNotSupported="Cannot use AccessDataSource '{0}' at design time when the DataFile property is specified using a virtual path.";
	public const string AccessDataSource_NoPathDiscoveryPermission="Access to the file '{0}' in AccessDataSource '{1}' was denied because of security settings.";
	public const string AccessDataSourceView_SelectRequiresDataFile="To perform the 'Select' operation the DataFile property of the data source '{0}' must be set to a valid Microsoft Access database.";
	public const string SqlDataSource_Description="Connect to any SQL database supported by ADO.NET, such as Microsoft SQL Server, Oracle, or OLEDB.";
	public const string SqlDataSource_DisplayName="Database";
	public const string SqlDataSource_InvalidMode="The SqlDataSourceMode for the DataSourceMode property on data source '{0}' is invalid.";
	public const string SqlDataSource_SqlCacheDependencyNotSupported="SQL Cache Dependencies are not supported by the data source '{0}'. If this control is derived from SqlDataSource and has its own cache implementation it must also override the SaveDataToCache() method.";
	public const string SqlDataSource_NoDbPermission="Access to the ADO.net Managed Provider '{0}' was denied in the data source with ID '{1}' because of security settings.";
	public const string SqlDataSourceView_SortNotSupported="The data source '{0}' only supports sorting when the data source's DataSourceMode is set to DataSet.";
	public const string SqlDataSourceView_FilterNotSupported="The data source '{0}' only supports filtering when the data source's DataSourceMode is set to DataSet.";
	public const string SqlDataSourceView_CacheNotSupported="The data source '{0}' only supports caching when the data source's DataSourceMode is set to DataSet.";
	public const string SqlDataSourceView_DeleteNotSupported="Deleting is not supported by data source '{0}' unless DeleteCommand is specified.";
	public const string SqlDataSourceView_InsertNotSupported="Inserting is not supported by data source '{0}' unless InsertCommand is specified.";
	public const string SqlDataSourceView_UpdateNotSupported="Updating is not supported by data source '{0}' unless UpdateCommand is specified.";
	public const string SqlDataSourceView_CouldNotCreateConnection="The data source '{0}' could not create a database connection. Please check the data source's connection settings.";
	public const string SqlDataSourceView_NoPaging="The SqlDataSource '{0}' does not have paging enabled.  Set the DataSourceMode to DataSet to enable paging.";
	public const string SqlDataSourceView_NoSorting="The SqlDataSource '{0}' cannot sort.  Set DataSourceMode to DataSet to enable sorting. If you are using a stored procedure that supports sorting, set the SortParameterName property to the name of the stored procedure's parameter that accepts a sort expression.";
	public const string SqlDataSourceView_NoRowCount="The SqlDataSource'{0}' cannot retrieve the total row count of the data source.";
	public const string SqlDataSourceView_CountNotValid="The SelectCountCommand on SqlDataSource '{0}' did not return a count of the rows in the data source.  Please check the SelectCountCommand.";
	//SqlDataSourceView_PageReaderNotSupported="The DbCommand created by SqlDataSource '{0}' does not support paged data reader.  Either change the provider in your connection string or change the DataSourceMode to DataSet.
	public const string SqlDataSourceView_SortParameterRequiresStoredProcedure="The SortParameterName property is only supported with stored procedure commands in SqlDataSource '{0}'.";
	public const string SqlDataSourceView_CommandNotificationNotSupported="SQL Server command notification for caching is only supported with the System.Data.SqlClient provider in SqlDataSource '{0}'.";
	public const string SqlDataSourceView_Pessimistic="You have specified that your {0} command compares all values on SqlDataSource '{1}', but the dictionary passed in for {2} is empty.  Pass in a valid dictionary for {0} or change your mode to OverwriteChanges.";
	public const string SqlDataSourceView_MissingParameters="Error executing '{0}Command' in SqlDataSource '{1}'. Ensure the command accepts the following parameters: {2}";
	public const string SqlDataSourceView_NoParameters="No Parameters";
	public const string DataSourceView_delete="delete";
	public const string DataSourceView_update="update";
	public const string ModelDataSourceView_CannotCallOpenGenericMethods="Cannot call the method '{0}' on page '{1}' because the method is a generic method.";
	public const string ModelDataSourceView_CannotCallMethodsWithOutOrRefParameters="Cannot call the method '{0}' on page '{1}' because the parameter '{2}' is passed by reference.";
	public const string ModelDataSourceView_DataMethodNotFound="A public method with the name '{0}' was either not found or there were multiple methods with the same name on the type '{1}'.";
	public const string ModelDataSourceView_DeleteNotSupported="Deleting is not supported unless the DeleteMethod is specified.";
	public const string ModelDataSourceView_InvalidSelectReturnType="The Select Method must return one of "IQueryable<{0}>" or "IEnumerable<{0}>" or "{0}" when ItemType is set to "{0}".";
	public const string ModelDataSourceView_InvalidPagingParameters="When the DataBoundControl has paging enabled, either the SelectMethod should return an IQueryable<ItemType> or should have all these mandatory parameters : int startRowIndex, int maximumRows, out int totalRowCount";
	public const string ModelDataSourceView_InvalidSortingParameters="When the DataBoundControl has sorting enabled, either the SelectMethod should return an IQueryable<ItemType> or should have all these mandatory parameters : string sortByExpression";
	public const string ModelDataSourceView_InsertNotSupported="Inserting is not supported unless the InsertMethod is specified.";
	public const string ModelDataSourceView_MultipleModelMethodSources="The DataMethodsType and DataMethodsObject properties cannot both be specified at the same time.";
	public const string ModelDataSourceView_MultipleValueProvidersNotSupported="Only one source for the parameter '{0}' can be specified.";
	public const string ModelDataSourceView_UpdateNotSupported="Updating is not supported unless the UpdateMethod is specified.";
	public const string ModelDataSourceView_SelectNotSupported="The Select operation is not supported unless the SelectMethod is specified.";
	public const string ModelDataSourceView_SortNotSupportedOnIEnumerable="The SelectMethod does not support sorting with IEnumerable data. Automatic sorting is only supported when the SelectMethod returns an IQueryable type.";
	public const string ModelDataSourceView_ParameterCannotBeNull="A null value for parameter '{0}' of non-nullable type '{1}' for method '{2}' in '{3}'. An optional parameter must be a reference type or a nullable type.";
	public const string ModelDataSourceView_ParameterValueHasWrongType="An invalid value for parameter '{0}' for method '{1}' in '{2}'. The value from model binding is of type '{3}', but the parameter requires a value of type '{4}'.";
	public const string ObjectDataSource_Description="Connect to a middle-tier business object or DataSet in the Bin or App_Code directory for the application.";
	public const string ObjectDataSource_DisplayName="Object";
	public const string ObjectDataSourceView_DeleteNotSupported="Deleting is not supported by ObjectDataSource '{0}' unless the DeleteMethod is specified.";
	public const string ObjectDataSourceView_InsertNotSupported="Inserting is not supported by ObjectDataSource '{0}' unless the InsertMethod is specified.";
	public const string ObjectDataSourceView_UpdateNotSupported="Updating is not supported by ObjectDataSource '{0}' unless the UpdateMethod is specified.";
	public const string ObjectDataSourceView_SelectNotSupported="The Select operation is not supported by ObjectDataSource '{0}' unless the SelectMethod is specified.";
	public const string ObjectDataSourceView_InsertRequiresValues="ObjectDataSource '{0}' has no values to insert. Check that the 'values' dictionary contains values.";
	public const string ObjectDataSourceView_TypeNotSpecified="A type must be specified in the TypeName property of ObjectDataSource '{0}'.";
	public const string ObjectDataSourceView_TypeNotFound="The type specified in the TypeName property of ObjectDataSource '{0}' could not be found.";
	public const string ObjectDataSourceView_MethodNotFoundNoParams="ObjectDataSource '{0}' could not find a non-generic method '{1}' that has no parameters.";
	public const string ObjectDataSourceView_MethodNotFoundWithParams="ObjectDataSource '{0}' could not find a non-generic method '{1}' that has parameters: {2}.";
	public const string ObjectDataSourceView_MethodNotFoundForDataObject="ObjectDataSource '{0}' could not find a non-generic method '{1}' that takes parameters of type '{2}'.";
	public const string ObjectDataSourceView_DataObjectTypeNotFound="The data object type specified in the DataObjectTypeName property of ObjectDataSource '{0}' could not be found.";
	public const string ObjectDataSourceView_DataObjectPropertyNotFound="Could not find a property named '{0}' on the type specified by the DataObjectTypeName property in ObjectDataSource '{1}'.";
	public const string ObjectDataSourceView_DataObjectPropertyReadOnly="The '{0}' property on the type specified by the DataObjectTypeName property in ObjectDataSource '{1}' is readonly and its value cannot be set.";
	public const string ObjectDataSourceView_MultipleOverloads="More than one method with the specified name and parameters was found for ObjectDataSource '{0}'. Adding the DataObjectMethodAttribute to one of these methods and/or making it the default method can help resolve overload conflicts.";
	//ObjectDataSourceView_CacheNotSupported="The data source '{0}' only supports caching when the SelectMethod returns a DataSet or a DataTable.
	public const string ObjectDataSourceView_CacheNotSupportedOnSortedDataView="The data source '{0}' only supports DataView caching when there is no sort expression.";
	public const string ObjectDataSourceView_CacheNotSupportedOnIDataReader="The data source '{0}' does not support caching objects that implement IDataReader.";
	public const string ObjectDataSourceView_SortNotSupportedOnIEnumerable="The data source '{0}' does not support sorting with IEnumerable data. Automatic sorting is only supported with DataView, DataTable, and DataSet.";
	public const string ObjectDataSourceView_FilterNotSupported="The data source '{0}' only supports filtering when the SelectMethod returns a DataSet or a DataTable.";
	public const string ObjectDataSourceView_Pessimistic="You have specified that your {0} method compares all values on ObjectDataSource '{1}', but the dictionary passed in for {2} is empty.  Pass in a valid dictionary for {0} or change your mode to OverwriteChanges.";
	public const string ObjectDataSourceView_NoOldValuesParams="The Update method on ObjectDataSource '{0}' must have a parameter that fits the OldValuesParameterFormatString.  Check your UpdateMethod or change your ConflictDetection to OverwriteValues.";
	public const string ObjectDataSourceView_MissingPagingSettings="In ObjectDataSource '{0}' when EnablePaging is set to true, StartRowIndexParameterName and MaximumRowsParameterName must also be set to valid parameter names of the SelectMethod.";
	public const string ObjectDataSourceView_CannotConvertType="Cannot convert value of parameter '{0}' from '{1}' to '{2}'";
	public const string FilteredDataSetHelper_DataSetHasNoTables="The DataSet in data source '{0}' does not contain any tables.";
	public const string StringPropertyBuilder_CannotHaveChildObjects="The '{0}' property of '{1}' does not allow child objects.";
	public const string XmlHierarchyData_CouldNotFindNode="Could not find node index. XmlNode does not exist in parent.";
	public const string XmlDataSource_Description="Connect to an XML file.";
	public const string XmlDataSource_DesignTimeRelativePathsNotSupported="Cannot use XmlDataSource '{0}' at design time when a file property is specified using a virtual path.";
	public const string XmlDataSource_DisplayName="XML File";
	public const string XmlDataSource_SaveNotAllowed="Save is not enabled in XmlDataSource '{0}' when either an XSL transform is specified, the content was specified using the Data property, the content was loaded from a URL, or a custom virtual path provider was used.";
	public const string XmlDataSource_NoWebPermission="Access to the URL '{0}' was denied in the XmlDataSource with ID '{1}' because of security settings.";
	public const string XmlDataSource_CannotChangeWhileLoading="The {0} property of XmlDataSource '{1}' cannot be changed while the document is being loaded.";
	public const string XmlDataSource_NeedUniqueIDForCache="When caching is enabled for the XmlDataSource that is not in the page's control tree it requires a UniqueID that is unique throughout the application.";
	public const string XmlDataSource_CacheKeyContext="Allows the user to specify a string that will be added to the cache key.";

	public const string DataControlFieldCell_ShouldNotSetValidateRequestMode="DataControlFieldCell gets the value of ValidateRequestMode from its ContainingField. The ValidateRequestMode property cannot be set directly on DataControlFieldCell.";

	public const string NeedHeader="Using {0} requires Page.Header to be non-null (e.g. <head runat=""server" />).";
	public const string Form_Required_For_Focus="A form tag with runat="server must exist on the Page to use SetFocus() or the Focus property.";
	public const string Page_MustCallBeforeAndDuringPreRender="{0} can only be called before and during PreRender.";
	//Control_MustCallBeforeAndDuringPreRender="{0} must be called before and during PreRender.
	public const string RoleGroupCollection_InvalidType="Argument must be a RoleGroup.";
	public const string Page_CallBackError="There was an error in the callback.";
	public const string Page_CallBackInvalid="The callback request is invalid.";
	public const string Page_CallBackTargetInvalid="The target '{0}' for the callback could not be found or did not implement ICallbackEventHandler.";
	public const string NoThemingSupport="Control of type '{0}' does not support theming.";
	public const string ControlNonVisual="Control of type '{0}' is a non-visual control and does not support setting the Visible property.";
	public const string NoFocusSupport="Control of type '{0}' does not support the Focus operation.";
	public const string PageStatePersister_PageCannotBeNull="A PageStatePersister must be constructed with a non-null Page reference.";
	public const string SessionPageStatePersister_SessionMustBeEnabled="SessionPageStatePersister can only be used when enableSessionState is set to true, either in a configuration file or in the Page directive.";
	public const string Page_MissingDataBindingContext="Databinding methods such as Eval(), XPath(), and Bind() can only be used in the context of a databound control.";
	public const string TemplateControl_DataBindingRequiresPage="Databinding methods such as Eval(), XPath(), and Bind() can only be used in controls contained in a page.";
	public const string LabelForNotFound="Unable to find control with id '{0}' that is associated with the Label '{1}'.";
	public const string Attrib_Sql9_not_allowed="The SqlDependency attribute does not support "CommandNotification" in a user control.";

	public const string FactoryGenerator_TypeNotPublic="Cannot instantiate type '{0}' because it is not public.";
	public const string FactoryGenerator_TypeHasNoParameterlessConstructor="Cannot instantiate type '{0}' because there is no public parameterless constructor.";
	public const string FactoryInterface="factoryInterface";

	// Serialization and persistence related
	public const string InvalidSerializedData="The serialized data is invalid.";
	public const string NonSerializableType="A value of type '{0}' cannot be serialized.";
	public const string ErrorSerializingValue="Error serializing value '{0}' of type '{1}.'";
	//CantBinarySerializeTypeInCodeDir="Cannot serialize value of type '{0}' because it is automatically compiled by ASP.NET.

	// Metadata Descriptions
	public const string Control_ValidateRequestMode="Determines whether the control validates client input or not. Defaults to inherit from parent.";
	public const string Control_Controls="The collection of child controls owned by the control.";
	public const string Control_ID="Programmatic name of the control.";
	public const string Control_MaintainState="Whether the control automatically saves its state for use in round-trips.";
	public const string Control_ViewStateMode="Determines whether the control has viewstate enabled or not, defaults to inherit from parent.";
	public const string Control_Visible="Indicates whether the control is visible and rendered.";
	public const string Control_OnDisposed="Fires when the control has been disposed.";
	public const string Control_OnInit="Fires when the page has been initialized.";
	public const string Control_OnLoad="Fires when the page has been loaded.";
	public const string Control_OnUnload="Fires when the page is unloaded.";
	public const string Control_OnPreRender="Fires before the page is rendered.";
	public const string Control_OnDataBind="Fires when the control's data binding expressions are to be evaluated.";
	public const string Control_NamingContainer="The containing control or page within which ID is unique.";
	public const string Control_Page="The page containing the control.";
	public const string Control_Parent="The control containing this control.";
	public const string Control_TemplateSourceDirectory="The virtual directory of the Page or UserControl that contains this control.";
	public const string Control_TemplateControl="The TemplateControl that hosts this control.";
	public const string Control_Site="Site of the control.";
	public const string Control_State="Current viewstate of the control.";
	public const string Control_UniqueID="The unique ID of the control within the page.";
	public const string Control_ClientID="The ID of the control that is rendered for the client.";
	public const string Control_ClientIDMode="Indicates how the ClientID should be generated for the control.";
	public const string Control_SkinId="The SkinId of the control skin that provides the skin of the control.";
	public const string Control_EnableTheming="Indicates whether the control can be themed.";
	public const string Page_ClientTarget="Allows you to override automatic detection of browser capabilities and force specific rendering.";
	public const string Page_ErrorPage="URL of the associated error page.";
	public const string Page_Error="Occurs when an uncaught exception is thrown.";
	public const string Page_OnCommitTransaction="Occurs when a user initiates a transaction.";
	public const string Page_OnAbortTransaction="Occurs when a user aborts a transaction.";
	public const string Page_Illegal_MaxPageStateFieldLength="MaxPageStateFieldLength can only be set to -1[off] or positive numbers.";
	public const string Page_Illegal_AsyncTimeout="AsyncTimeout cannot be negative.";
	public const string Page_InvalidUpdateModelAttempt="'{0}' must be passed a value provider or alternatively must be invoked from inside a data-operation method of a control that uses model binding for data binding.";
	public const string Page_UnobtrusiveValidationMode="Specifies the client side validation mode of the validators on this page.";
	public const string Page_UpdateModel_UpdateUnsuccessful="The model of type '{0}' could not be updated.";
	public const string ObjectDataSource_ConflictDetection="Specifies how data conflicts are resolved.";
	public const string ObjectDataSource_ConvertNullToDBNull="Specifies whether null parameter values passed into methods will be converted to System.DBNull.";
	public const string ObjectDataSource_DataObjectTypeName="Specifies a type that can be constructed for Update, Insert, and Delete operations when the method takes this type rather than having one parameter for each property.";
	public const string ObjectDataSource_DeleteMethod="The method to execute when Delete() is called.";
	public const string ObjectDataSource_DeleteParameters="Collection of parameters used when calling the DeleteMethod. These parameters are merged with the parameters provided by data-bound controls.";
	public const string ObjectDataSource_EnablePaging="Indicates whether the Select method supports paging.";
	public const string ObjectDataSource_FilterExpression="Filter expression used when Select() is called. Filtering is only available when the SelectMethod returns a DataSet or a DataTable.";
	public const string ObjectDataSource_FilterParameters="Collection of parameters used in the FilterExpression property. Filtering is only available when the SelectMethod returns a DataSet or a DataTable.";
	public const string ObjectDataSource_InsertMethod="The method to execute when Insert() is called.";
	public const string ObjectDataSource_InsertParameters="Collection of values used when calling the InsertMethod. These parameters are merged with the parameters provided by data-bound controls.";
	public const string ObjectDataSource_MaximumRowsParameterName="When EnablePaging is true, this indicates the parameter of the Select method that accepts the value for the number of rows to retrieve.";
	public const string ObjectDataSource_SelectCountMethod="The method to execute when the total row count is needed.";
	public const string ObjectDataSource_SelectMethod="The method to execute when Select() is called.";
	public const string ObjectDataSource_SelectParameters="Collection of parameters used when calling the SelectMethod.";
	public const string ObjectDataSource_SortParameterName="The name of the parameter on the Select Method that accepts a sort expression, if any.";
	public const string ObjectDataSource_StartRowIndexParameterName="When EnablePaging is set to true, this property indicates the parameter of the Select method that accepts the value for the index of first row to retrieve.";
	public const string ObjectDataSource_TypeName="The type that contains the methods specified in this control.";
	public const string ObjectDataSource_UpdateMethod="The method to execute when Update() is called.";
	public const string ObjectDataSource_UpdateParameters="Collection of parameters and values used when calling the UpdateMethod. These parameters are merged with the parameters provided by data-bound controls.";
	public const string ObjectDataSource_ObjectCreated="This event is raised after the instance of the object has been created.";
	public const string ObjectDataSource_ObjectCreating="This event is raised before an instance of the object is created to allow creation of a custom instance of the object.";
	public const string ObjectDataSource_ObjectDisposing="This event is raised before the instance of the object is disposed.";
	public const string ObjectDataSource_Selected="This event is raised one time each after the Select and SelectCount operation have completed.";
	public const string ObjectDataSource_Selecting="This event is raised one time each before the Select and SelectCount operations have been executed.";
	public const string ObjectDataSource_ParsingCulture="Indicates the Culture used by ObjectDataSource when converting string values to actual types of properties of data object.";
	public const string DataSourceCache_Duration="The duration, in seconds, of the expiration. The expiration policy is specified by the ExpirationPolicy property.";
	public const string DataSourceCache_Enabled="Whether caching is enabled for this data source.";
	public const string DataSourceCache_ExpirationPolicy="The expiration policy of the cache. The duration for the expiration is specified by the Duration property.";
	public const string DataSourceCache_KeyDependency="Indicates an arbitrary cache key to make this cache entry depend on.";
	public const string SqlDataSource_ConflictDetection="Specifies how data conflicts are resolved.";
	public const string SqlDataSource_ConnectionString="The connection string used to connect to the database. This property is not stored in ViewState.";
	public const string SqlDataSource_CancelSelectOnNullParameter="Indicates whether the Select operation will be cancelled if the value of any of the SelectParameters is null.";
	public const string SqlDataSource_ProviderName="The ADO.net managed provider name used to connect to the database. This property is not stored in ViewState.";
	public const string SqlDataSource_DataSourceMode="Specifies the SqlDataSourceMode used for selecting rows.";
	public const string SqlDataSource_DeleteCommand="The command to execute for deleting rows.";
	public const string SqlDataSource_DeleteCommandType="The type of the delete command.";
	public const string SqlDataSource_DeleteParameters="Collection of parameters used in Delete(). These parameters are merged with the parameters provided by data-bound controls.";
	public const string SqlDataSource_FilterExpression="Filter expression used when Select() is called. Filtering is only available when the DataSourceMode is set to DataSet.";
	public const string SqlDataSource_FilterParameters="Collection of parameters used in the FilterExpression property. Filtering is only available when the DataSourceMode is set to DataSet.";
	public const string SqlDataSource_InsertCommand="The command to execute for inserting new rows.";
	public const string SqlDataSource_InsertCommandType="The type of the insert command.";
	public const string SqlDataSource_InsertParameters="Collection of values used in Insert(). These parameters are merged with the parameters provided by data-bound controls.";
	public const string SqlDataSource_SelectCommand="The command to execute for selecting rows.";
	public const string SqlDataSource_SelectCommandType="The type of the select command.";
	//SqlDataSource_SelectCountCommand="The command executed to retrieve the total number of rows.
	//SqlDataSource_SelectCountParameters="Collection of parameters used for retrieving the total number of rows.
	public const string SqlDataSource_SelectParameters="Collection of parameters used for selecting rows.";
	public const string SqlDataSource_SortParameterName="The name of the parameter on the Select Command that accepts a sort expression, if any. This is only supported when using a stored procedure.";
	public const string SqlDataSource_UpdateCommand="The command to execute for updating rows.";
	public const string SqlDataSource_UpdateCommandType="The type of the update command.";
	public const string SqlDataSource_UpdateParameters="Collection of parameters and values used in Update(). These parameters are merged with the parameters provided by data-bound controls.";
	public const string SqlDataSource_Selected="This event is raised after the Select operation has completed.";
	public const string SqlDataSource_Selecting="This event is raised before the Select operation has been executed.";
	public const string SqlDataSourceCache_SqlCacheDependency="A semi-colon delimited string indicating which databases to use for the dependency in the format "database1:table1;database2:table2".";
	public const string Parameter_DbType="The database type of the parameter. If this property is set to DbType.Object, the Type property will be used instead.";
	public const string Parameter_DefaultValue="The default value to use if the value of the parameter is null.";
	public const string Parameter_Direction="The direction of the parameter.";
	public const string Parameter_Name="The name of the parameter.";
	public const string Parameter_Size="The maximum size of the parameter.";
	public const string Parameter_ConvertEmptyStringToNull="Whether an empty string should be treated as a null value. If this property is set to true and the value is an empty string, the default value will be used.";
	public const string Parameter_Type="The type of the parameter.";
	public const string Parameter_TypeNotSupported="The Type property of parameter '{0}' cannot be set when the DbType property is set.";
	public const string Parameter_ValidateInput="Determines whether the parameter's value is being validated or not.";
	public const string ControlParameter_ControlID="The ID of the control to get the property value from.";
	public const string ControlParameter_PropertyName="A property name indicating the property from which to get the value. If none is specified, the ControlValueProperty attribute of the control will be examined to determine the value.";
	public const string CookieParameter_CookieName="The name of the cookie to get the value from.";
	public const string QueryStringParameter_QueryStringField="The name of the query string field to get the value from.";
	public const string FormParameter_FormField="The name of the form field to get the value from.";
	public const string SessionParameter_SessionField="The name of the session field to get the value from.";
	public const string ProfileParameter_PropertyName="The profile property to get the value from.";

	public const string HtmlInputHidden_OnServerChange="Fires when the value of the control changes.";
	public const string HtmlInputImage_OnServerClick="Fires when the image is clicked.";
	public const string HtmlInputText_ServerChange="Fires when the text within the control changes.";
	public const string HtmlSelect_DataTextField="The field in the data source that provides the item text.";
	public const string HtmlSelect_DataValueField="The field in the data source that provides the item value.";
	public const string HtmlSelect_OnServerChange="Fires when the selection changes.";
	public const string HtmlSelect_DataMember="The data member of the select.";
	public const string HtmlTextArea_OnServerChange="Fires when the text within the control changes.";

	public const string AccessDataSource_DataFile="The name of a Microsoft Office Access database file.";
	public const string AdRotator_AdvertisementFile="XML file containing advertisements.";
	public const string AdRotator_AlternateTextField="The element name that specifies which alternate text to retrieve.";

	public const string AdRotator_ImageUrlField="The element name that specifies which image URL to retrieve.";
	public const string AdRotator_KeywordFilter="Keyword for limiting selection of advertisements.";
	public const string AdRotator_NavigateUrlField="The element name that specifies which advertisement Web page URL to retrieve.";
	public const string AdRotator_Target="The target frame for the NavigateUrl of the advertisement.";
	public const string AdRotator_OnAdCreated="Fired after an advertisement is retrieved from the AdvertisementFile.";

	public const string AssemblyResourceLoader_HandlerNotRegistered="The WebResource.axd handler must be registered in the configuration to process this request.\r\n\r\n<!-- Web.Config Configuration File -->\r\n\r\n<configuration>\r\n    <system.web>\r\n        <httpHandlers>\r\n            <add path=""WebResource.axd" verb=""GET" type=""System.Web.Handlers.AssemblyResourceLoader" validate=""True" />\r\n        </httpHandlers>\r\n    </system.web>\r\n</configuration>";
	public const string AssemblyResourceLoader_InvalidRequest="This is an invalid webresource request.";
	public const string AssemblyResourceLoader_AssemblyNotFound="Assembly {0} not found.";
	public const string AssemblyResourceLoader_ResourceNotFound="Resource {0} not found in assembly.";
	public const string AssemblyResourceLoader_NoCircularReferences="The resource '{0}' cannot contain a reference to itself.";

	public const string DataControls_ShowFooter="Whether to the show the control's footer.";
	public const string DataControls_ShowHeader="Whether to the show the control's header.";
	public const string DataControls_AutoGenerateColumns="Whether the columns are generated automatically at runtime based on the associated data source.";
	public const string Button_CausesValidation="Whether the button causes validation to fire.";
	public const string WebControl_RepeatLayout="Whether items are repeated in a table or in-flow.";
	public const string DataSource_Updating="This event is raised before the Update operation has been executed.";
	public const string DataSource_Inserting="This event is raised before the Insert operation has been executed.";
	public const string DataSource_Deleting="This event is raised before the Delete operation has been executed.";
	public const string DataSource_Updated="This event is raised after the Update operation has completed.";
	public const string DataSource_Inserted="This event is raised after the Insert operation has completed.";
	public const string DataSource_Deleted="This event is raised after the Delete operation has completed.";
	public const string TableItem_VerticalAlign="The vertical alignment of the cell content.";
	public const string Button_PostBackUrl="The URL to post to when the button is clicked.";
	public const string LoginControls_DefaultRequiredFieldValidatorText="*";
	public const string LoginControls_SuccessPageUrl="The URL that the user is directed to after the action has succeeded.";
	public const string LoginControls_EditProfileIconUrl="The URL of the icon for the edit profile page";
	public const string LoginControls_HelpPageIconUrl="The URL of the icon for the help page.";
	public const string LoginControls_HelpPageUrl="The URL of the help page.";
	public const string ChangePassword_ChangePasswordButtonImageUrl="The URL of an image to be displayed for the change password button.";
	public const string ChangePassword_ContinueButtonImageUrl="The URL of an image to be displayed for the continue button.";
	public const string PagerSettings_PreviousPageText="The text to be used on the previous page button.";
	public const string PagerSettings_NextPageText="The text to be used on the next page button.";
	public const string ChangePassword_UserNameRequiredErrorMessage="The text to be shown in the validation summary when the user name is empty.";
	public const string ChangePassword_ConfirmPasswordCompareErrorMessage="The text to be shown in the validation summary when the password and confirm password do not match.";
	public const string LoginControls_ConfirmPasswordRequiredErrorMessage="The text to be shown in the validation summary when the confirm password is empty.";
	public const string LoginControls_AnswerRequiredErrorMessage="The text to be shown in the validation summary when the answer is empty.";
	public const string LoginControls_TitleText="The text to be shown for the title.";
	public const string ChangePassword_PasswordRecoveryText="The text to be shown for the password recovery link.";
	public const string ChangePassword_ChangePasswordButtonText="The text to be shown for the change password button.";
	public const string ChangePassword_HelpPageText="The text to be shown for the help link.";
	public const string ChangePassword_CreateUserText="The text to be shown for the create user link.";
	public const string ChangePassword_SuccessText="The text to be shown after the password has been changed.";
	public const string LoginControls_UserNameLabelText="The text that identifies the user name textbox.";
	public const string WebControl_SkipLinkText="The text that appears in the ALT attribute of the invisible image link that allows screen readers to skip repetitive content.";
	public const string View_HeaderText="The text shown in the header if no HeaderTemplate is defined.";
	public const string View_FooterText="The text shown in the footer if no FooterTemplate is defined.";
	public const string View_EmptyDataText="The text shown in the empty data row if no EmptyDataTemplate is defined.";
	public const string BoundField_NullDisplayText="The text displayed if the data bound to the field is null.";
	public const string View_PagerTemplate="The template used for the pager.";
	public const string WebControl_HeaderTemplate="The template used for the header.";
	public const string View_EmptyDataTemplate="The template used for the control when no items are returned from the data source.";
	public const string LoginControls_TitleTextStyle="The style of the title.";
	public const string LoginControls_TextBoxStyle="The style of the textboxes.";
	public const string LoginControls_LabelStyle="The style of the textbox labels.";
	//Table_SummaryTitleStyle="The style of the mobile summary title.
	public const string WebControl_InstructionTextStyle="The style of the instructions.";
	public const string WebControl_HyperLinkStyle="The style of the hyperlinks.";
	public const string WebControl_FailureTextStyle="The style of the failure text.";
	//Table_DetailLinkStyle="The style for the links shown in mobile details view.
	public const string View_EmptyDataRowStyle="The style applied to the row that contains the EmptyDataTemplate.";
	public const string WebControl_HeaderStyle="The style applied to the header.";
	public const string View_RowStyle="The style applied to rows.";
	public const string View_InsertRowStyle="The style applied to rows when the control is in insert mode.";
	public const string View_EditRowStyle="The style applied to rows when the control is in edit mode.";
	public const string DataControls_Columns="The set of columns to be shown in the control.";
	public const string HotSpot_Target="The name of the window/frame into which the navigation URL should be opened.";
	public const string MembershipProvider_Name="The name of the membership provider.";
	public const string View_DefaultMode="The mode that the control will begin in, and will revert to after a Cancel, Insert, or Update command.";
	public const string LoginControls_TextLayout="The layout of the labels in relation to the textboxes.";
	public const string UserName_InitialValue="The initial value in the user name textbox.";
	public const string WebControl_SelectedIndex="The index of the currently selected item.";
	public const string View_DataSourceReturnedNullView="The IDataSource that is the data source for DetailsView '{0}' returned a null view.  Check that the DataMember property value of DetailsView is valid.";
	public const string WebControl_HorizontalAlign="The horizontal alignment of the control.";
	public const string TableItem_HorizontalAlign="The horizontal alignment of the cell content.";

	public const string DataSource_OldValuesParameterFormatString="The format string applied to the parameter names of the old values passed in an update command when old data values are being compared for conflicts. For example, "Original_{0}". To remove the prefix, specify "{0}" for the value of this property.";
	public const string Binding_DataMember="The element or table name that contains the attributes or columns specified by TextField and ValueField.";
	public const string Item_RepeatDirection="The direction in which items are laid out.";
	public const string DataControls_Caption="The descriptive caption associated with the control.";
	//DataControl_SummaryViewColumn="The data source field corresponding to the mobile summary view.
	public const string DataSource_InvalidViewName="The data source '{0}' only supports a single view named '{1}'. You may also leave the view name (also called a data member) empty for the default view to be chosen.";
	public const string WebControl_CommandName="The command associated with the button.";
	public const string WebControl_CommandArgument="The command argument associated with the button.";
	public const string WebControl_BackImageUrl="The background image within the control.";
	public const string WebControl_TextAlign="The alignment of the text label with respect to each item.";
	public const string WebControl_CaptionAlign="The alignment of the associated caption.";
	public const string WebControl_InstructionText="Text that is displayed to give instructions.";
	public const string DataControls_HeaderStyle="Style applied to the header.";
	public const string DataControls_FooterStyle="Style applied to the footer.";
	public const string HotSpot_HotSpotMode="Specifies whether the image map causes postback or navigation behavior.";
	public const string DataControls_GridLines="Settings for grid lines between cells.";
	public const string Password_InvalidPasswordErrorMessage="Please enter a different password.";
	public const string Table_UseAccessibleHeader="Indicates that the control should use accessible header cells in its containing table control.";
	public const string HtmlControl_OnServerClick="Fires when the control is clicked.";
	public const string Button_OnCommand="Fires when the button is clicked and an associated command is defined.";
	public const string Control_OnServerCheckChanged="Fires when the checked state of the control changes.";
	public const string DataControls_OnItemUpdated="Fires after an Update Command is executed on the data source.";
	public const string DataControls_OnItemDeleting="Fires before a Delete Command is executed on the data source.";
	public const string DataControls_OnItemInserting="Fires before an Insert Command is executed on the data source.";
	public const string DataControls_OnItemUpdating="Fires before an Update Command is executed on the data source.";
	public const string DataControls_OnItemCreated="Fires when an item is created.";
	public const string DataControls_OnItemDataBound="Fires after an item has been databound.";
	public const string DataControls_OnItemDeleted="Fires after a Delete Command is executed on the data source.";
	public const string DataControls_OnItemInserted="Fires after an Insert Command is executed on the data source.";
	public const string DataControls_DataKeyNames="A comma-separated list of key fields in the data source.";
	public const string DataControls_DataSourceMustBeCollectionWhenNotDataBinding="Data source must implement ICollection when calling CreateChildControls with dataBinding="false.";
	public const string DataControls_OnRowDeleted="Fires after a Delete Command is executed on the data source.";
	public const string DataSource_Filtering="This event is raised before the filter expression is applied to the data.";
	public const string WebControl_PagerStyle="Controls the paging UI style associated with the control.";
	public const string WebControl_CantFindProvider="Could not find the specified membership provider.";

	public const string BaseDataList_CellPadding="The padding within cells.";
	public const string BaseDataList_CellSpacing="The spacing between cells.";
	public const string BaseDataList_DataKeyField="The field in the data source used to populate the DataKeys collection.";
	public const string BaseDataList_DataKeys="The collection of data keys.";
	public const string BaseDataList_DataMember="The table or view used for binding when a DataSet is used as a data source.";
	public const string BaseDataList_OnSelectedIndexChanged="Fires when the current selection changes.";
	public const string BaseValidator_ControlToValidate="ID of the control to validate.";
	public const string BaseValidator_ErrorMessage="Message to display in a ValidationSummary when the validated control is invalid.";
	public const string BaseValidator_IsValid="Indicates whether the validated control is in error.";
	public const string BaseValidator_Display="How the validator is displayed.";
	public const string BaseValidator_EnableClientScript="Indicates whether to perform validation on the client in up-level browsers.";
	public const string BaseValidator_SetFocusOnError="Whether the validator sets focus on the control when invalid.";
	public const string BaseValidator_Text="Text to display for the validator when the validated control is invalid.";
	public const string BaseValidator_ValidationGroup="The group to which the validator belongs.";
	public const string BaseCompareValidator_CultureInvariantValues="Whether we should do culture invariant conversion against the string value properties on the validator.";
	public const string BoundColumn_DataField="The field to which this column is bound.";
	public const string BoundColumn_DataFormatString="The formatting that is applied to the bound value. For example, "{0:d}" or "{0:c}".";
	public const string BoundColumn_ReadOnly="Whether the column does not permit editing of its bound field.";
	public const string BoundField_ApplyFormatInEditMode="Whether the data should be shown with the DataFormatString formatting applied when in edit mode.  If set to true, the data may have to be unformatted before it is updated in the data source.";
	public const string BoundField_DataField="The field to which this field is bound.";
	public const string BoundField_DataFormatString="The formatting that is applied to the bound value. For example, "{0:d}" or "{0:c}".";
	public const string BoundField_HtmlEncode="Whether the field is HTML encoded when displayed to the user.";
	public const string BoundField_ReadOnly="Whether the field does not permit editing of its bound field.";
	public const string BoundField_ConvertEmptyStringToNull="Whether the field treats empty strings as null when the value is extracted from the field.";
	public const string BulletedList_BulletedListDisplayMode="The display mode of the bulleted list.";
	public const string BulletedList_BulletImageUrl="The URL of an image to use as bullets.";
	public const string BulletedList_BulletStyle="The Style used for the bullets.";
	public const string BulletedList_FirstBulletNumber="The value at which an ordered list begins numbering.";
	public const string BulletedList_Target="The target frame for the URL.";
	public const string BulletedList_OnClick="Fires when any linkbutton in list is clicked.";
	public const string Button_OnClientClick="The client-side script that is executed on a client-side OnClick.";
	public const string ButtonColumn_ButtonType="The type of button contained within the column.";
	public const string ButtonColumn_CausesValidation="Whether pressing the button will cause validation to occur.";
	public const string ButtonColumn_DataTextField="The field bound to the text property of the button.";
	public const string ButtonColumn_DataTextFormatString="The formatting applied to the value bound to the Text property. For example, "select: {0}".";
	public const string ButtonColumn_Text="The text used for the button.";
	public const string ButtonColumn_ValidationGroup="The name of the validation group for which this button should cause validation.";
	//Button_SoftkeyLabel="The label shown when the Button is mapped to a mobile device softkey.
	public const string Button_Text="The text to be shown on the button.";
	public const string Button_OnClick="Fires when the button is clicked.";
	public const string Button_UseSubmitBehavior="Indicates whether the button render as a submit button.";
	public const string CheckBox_AutoPostBack="Automatically posts back to the server when the control is clicked.";
	public const string CheckBox_Checked="The checked state of the control.";
	public const string CheckBox_InputAttributes="Attributes to be rendered on the HTML input element.";
	public const string CheckBox_LabelAttributes="Attributes to be rendered on the HTML span element associated with the checkbox text.";
	public const string CheckBox_Text="The text label shown with the check box.";

	public const string CheckBoxField_Text="The Text property of the CheckBox in this field.";

	public const string CheckBoxList_CellPadding="The padding between each item.";
	public const string CheckBoxList_CellSpacing="The spacing between each item.";
	public const string CheckBoxList_RepeatColumns="The number of columns used to lay out the items.";
	public const string CircleHotSpot_X="The x coordinate of the circle center.";
	public const string CircleHotSpot_Y="The y coordinate of the circle center.";
	public const string CircleHotSpot_Radius="The radius of the circular hot spot.";
	public const string CommandField_DefaultCancelCaption="Cancel";
	public const string CommandField_DefaultDeleteCaption="Delete";
	public const string CommandField_DefaultEditCaption="Edit";
	public const string CommandField_DefaultInsertCaption="Insert";
	public const string CommandField_DefaultNewCaption="New";
	public const string CommandField_DefaultSelectCaption="Select";
	public const string CommandField_DefaultUpdateCaption="Update";
	public const string CommandField_CancelImageUrl="The URL of the image to be displayed as the cancel button.";
	public const string CommandField_DeleteImageUrl="The URL of the image to be displayed as the delete button.";
	public const string CommandField_EditImageUrl="The URL of the image to be displayed as the edit button.";
	public const string CommandField_InsertImageUrl="The URL of the image to be displayed as the insert button.";
	public const string CommandField_NewImageUrl="The URL of the image to be displayed as the new button.";
	public const string CommandField_SelectImageUrl="The URL of the image to be displayed as the select button.";
	public const string CommandField_UpdateImageUrl="The URL of the image to be displayed as the update button.";
	public const string CommandField_ShowDeleteButton="Whether the field should display a delete button to the user.";
	public const string CommandField_ShowCancelButton="Whether the field should display a cancel button to the user.";
	public const string CommandField_ShowInsertButton="Whether the field should display an insert button to the user.";
	public const string CommandField_ShowEditButton="Whether the field should display an edit button to the user.";
	public const string CommandField_ShowSelectButton="Whether the field should display a select button to the user.";
	public const string CommandField_CancelText="The text to be displayed on the cancel button.";
	public const string CommandField_DeleteText="The text to be displayed on the delete button.";
	public const string CommandField_EditText="The text to be displayed on the edit button.";
	public const string CommandField_InsertText="The text to be displayed on the insert button.";
	public const string CommandField_NewText="The text to be displayed on the new button.";
	public const string CommandField_SelectText="The text to be displayed on the select button.";
	public const string CommandField_UpdateText="The text to be displayed on the update button.";

	public const string ButtonFieldBase_ButtonType="The type of the button to be rendered in the field.  The values are Link, Button, and Image.";
	public const string ButtonFieldBase_CausesValidation="Whether pressing the button will cause validation to occur.";
	public const string ButtonFieldBase_ValidationGroup="The name of the validation group for which this button should cause validation.";
	public const string ButtonField_DataTextField="The field bound to the text property of the button.";
	public const string ButtonField_DataTextFormatString="The formatting applied to the value bound to the Text property. For example, "select: {0}".";
	public const string ButtonField_ImageUrl="The URL of the image if the ButtonType is Image.";
	public const string ButtonField_Text="The text used for the button.";

	public const string ChangePassword_CancelButtonType="The type of the cancel button.";
	public const string ChangePassword_ContinueButtonType="The type of the continue button.";
	public const string ChangePassword_ChangePasswordButtonType="The type of the change password button.";
	public const string ChangePassword_CancelButtonImageUrl="The URL of an image to be displayed for the cancel button.";
	public const string ChangePassword_CancelButtonText="The text of the cancel button.";
	public const string ChangePassword_CancelButtonStyle="The style of the cancel button.";
	public const string ChangePassword_CancelButtonClick="Raised when the cancel button is clicked";
	public const string ChangePassword_CancelDestinationPageUrl="The URL to redirect to when the cancel button is clicked.";
	public const string ChangePassword_ChangePasswordError="Raised if the change password attempt fails.";
	public const string ChangePassword_ChangedPassword="Raised after the password has been changed.";
	public const string ChangePassword_ChangingPassword="Raised before the change password attempt.";
	public const string ChangePassword_ChangePasswordFailureText="The text to be shown when the change password attempt fails";
	public const string ChangePassword_ContinueButtonClick="Raised when the continue button is clicked";
	public const string LoginControls_ContinueDestinationPageUrl="The URL to redirect to when the continue button is clicked.";
	public const string ChangePassword_ContinueButtonText="The text of the continue button.";
	public const string ChangePassword_ContinueButtonStyle="The style of the continue button.";
	public const string ChangePassword_CreateUserIconUrl="The URL of the icon for the create user page.";
	public const string ChangePassword_CreateUserUrl="The URL of the create user page.";
	public const string ChangePassword_DefaultChangePasswordTitleText="Change Your Password";
	public const string ChangePassword_DefaultChangePasswordFailureText="Password incorrect or New Password invalid. New Password length minimum: {0}. Non-alphanumeric characters required: {1}.";
	public const string ChangePassword_DefaultCancelButtonText="Cancel";
	public const string ChangePassword_DefaultConfirmPasswordRequiredErrorMessage="Confirm New Password is required.";
	public const string ChangePassword_DefaultConfirmNewPasswordLabelText="Confirm New Password:";
	public const string ChangePassword_DefaultContinueButtonText="Continue";
	public const string ChangePassword_DefaultNewPasswordLabelText="New Password:";
	public const string ChangePassword_DefaultNewPasswordRequiredErrorMessage="New Password is required.";
	public const string ChangePassword_DefaultConfirmPasswordCompareErrorMessage="The Confirm New Password must match the New Password entry.";
	public const string ChangePassword_DefaultPasswordRequiredErrorMessage="Password is required.";
	public const string ChangePassword_DefaultChangePasswordButtonText="Change Password";

	public const string ChangePassword_DefaultSuccessTitleText="Change Password Complete";
	public const string ChangePassword_DefaultSuccessText="Your password has been changed!";

	public const string ChangePassword_DefaultUserNameLabelText="User Name:";
	public const string ChangePassword_DefaultUserNameRequiredErrorMessage="User Name is required.";
	public const string ChangePassword_EditProfileText="The text to be shown for the edit link.";
	public const string ChangePassword_EditProfileUrl="The URL of the edit profile page";
	public const string ChangePassword_DisplayUserName="True if the user name text box should be shown";
	//ChangePassword_FailureTextWrongType="FailureText control with ID {0} inside the ChangePasswordTemplate must be of type IStaticTextControl.
	public const string ChangePassword_InvalidBorderPadding="BorderPadding must be greater than or equal to -1.";
	//ChangePassword_LoginError="Raised if the authentication fails.

	public const string ChangePassword_PasswordHintText="Text that is displayed to give password guidelines.";

	public const string ChangePassword_MailDefinition="The content and format of the e-mail message that contains the successful change password notification.";


	public const string ChangePassword_NewPasswordRegularExpressionErrorMessage="The text to be shown when the new password regular expression fails.";
	public const string ChangePassword_NewPasswordLabelText="The text that identifies the new password textbox.";
	public const string ChangePassword_NewPasswordRegularExpression="Regular expression specification for valid new passwords.";
	public const string ChangePassword_NewPasswordRequiredErrorMessage="The text to be shown in the validation summary when the new password is empty.";

	public const string ChangePassword_NoCurrentPasswordTextBox="{0}: ChangePasswordTemplate does not contain an IEditableTextControl with ID {1} for the current password.";
	public const string ChangePassword_NoNewPasswordTextBox="{0}: ChangePasswordTemplate does not contain an IEditableTextControl with ID {1} for the new password.";

	public const string ChangePassword_NoUserNameTextBox="{0}: ChangePasswordTemplate does not contain an IEditableTextControl with ID {1} for the username, this is required if DisplayUserName="true.";
	public const string ChangePassword_UserNameTextBoxNotAllowed="{0}: ChangePasswordTemplate contains an IEditableTextControl with ID {1} for the username, this is not allowed if DisplayUserName="false.";
	public const string ChangePassword_PasswordHintStyle="The style of the password hint";
	public const string ChangePassword_PasswordRecoveryIconUrl="The URL of the icon for the password recovery link.";
	public const string ChangePassword_PasswordRecoveryUrl="The URL of the password recovery page.";
	public const string ChangePassword_PasswordRequiredErrorMessage="The text to be shown in the validation summary when the password is empty.";
	public const string ChangePassword_SendingMail="Raised before the e-mail is sent.";
	public const string ChangePassword_SendMailError="Raised when there is an error sending mail.";
	public const string ChangePassword_ChangePasswordButtonStyle="The style to be shown for the change password button.";
	public const string ChangePassword_SuccessTitleText="The text to be shown for the title on success";
	public const string ChangePassword_SuccessTextStyle="The style of the success text.";
	public const string ChangePassword_ConfirmNewPasswordLabelText="The text that identifies the confirm password textbox.";
	public const string ChangePassword_ValidatorTextStyle="The style of the validators' text.";

	public const string CompareValidator_ControlToCompare="ID of the control to compare with.";
	public const string CompareValidator_Operator="Comparison operation to apply to values.";
	public const string CompareValidator_ValueToCompare="Value to compare against.";
	public const string Content_ContentPlaceHolderID="The ID of the corresponding ContentPlaceHolder in the master page.";

	public const string ContentPlaceHolder_only_in_master="ContentPlaceHolder can only be used in .master files.";
	public const string ContentPlaceHolder_duplicate_contentPlaceHolderID="Duplicate ContentPlaceHolder '{0}' were found. ContentPlaceHolders require unique IDs.";
	public const string CreateUserWizard_AutoGeneratePassword="Determines if the control autogenerates a password for the user.";
	public const string CreateUserWizard_Answer="The initial value in the answer textbox.";
	public const string CreateUserWizard_InvalidAnswerErrorMessage="Text to be shown when the security answer is invalid.";
	public const string CreateUserWizard_AnswerLabelText="The text that identifies the answer textbox.";
	public const string CreateUserWizard_CompleteSuccessText="The text to be shown after the user has been created.";
	public const string CreateUserWizard_ContinueButtonType="The type of the continue button.";
	public const string CreateUserWizard_CreatingUser="Raised before the user is created.";
	public const string CreateUserWizard_CreatedUser="Raised after the user is created.";
	public const string CreateUserWizard_ConfirmPasswordLabelText="The text that identifies the confirm password textbox.";
	public const string CreateUserWizard_ContinueButtonText="The text of the continue button.";
	public const string CreateUserWizard_ContinueButtonStyle="The style of the continue button.";
	public const string CreateUserWizard_ContinueButtonClick="Raised when the continue button is clicked.";
	//CreateUserWizard_ContinueDestinationPageUrl="The URL of the continue page.
	public const string CreateUserWizard_CreateUserButtonImageUrl="The URL for the image of the create user button.";
	public const string CreateUserWizard_CreateUserButtonType="The type of the create user button.";
	public const string CreateUserWizard_CreateUserButtonText="The text of the create user button.";
	public const string CreateUserWizard_CreateUserButtonStyle="The style of the create user button.";
	public const string CreateUserWizard_CreateUserError="Raised when there is an error creating the user.";
	public const string CreateUserWizard_CreateUserStep="The create user WizardStep.";
	//CreateUserWizard_DefaultCancelButtonText="Cancel
	public const string CreateUserWizard_DefaultConfirmPasswordCompareErrorMessage="The Password and Confirmation Password must match.";
	public const string CreateUserWizard_DefaultConfirmPasswordRequiredErrorMessage="Confirm Password is required.";
	public const string CreateUserWizard_DefaultConfirmPasswordLabelText="Confirm Password:";
	public const string CreateUserWizard_DefaultContinueButtonText="Continue";
	public const string CreateUserWizard_DefaultCreateUserButtonText="Create User";
	public const string CreateUserWizard_DefaultDuplicateUserNameErrorMessage="Please enter a different user name.";
	public const string CreateUserWizard_DefaultDuplicateEmailErrorMessage="The e-mail address that you entered is already in use. Please enter a different e-mail address.";
	public const string CreateUserWizard_DefaultEmailLabelText="E-mail:";
	public const string CreateUserWizard_DefaultUnknownErrorMessage="Your account was not created. Please try again.";
	public const string CreateUserWizard_DefaultInvalidEmailErrorMessage="Please enter a valid e-mail address.";
	public const string CreateUserWizard_DefaultInvalidPasswordErrorMessage="Password length minimum: {0}. Non-alphanumeric characters required: {1}.";
	public const string CreateUserWizard_DefaultCompleteTitleText="Complete";
	public const string CreateUserWizard_DefaultPasswordRequiredErrorMessage="Password is required.";
	public const string CreateUserWizard_DefaultQuestionLabelText="Security Question:";
	public const string CreateUserWizard_DefaultInvalidQuestionErrorMessage="Please enter a different security question.";
	public const string CreateUserWizard_DefaultInvalidAnswerErrorMessage="Please enter a different security answer.";
	public const string CreateUserWizard_DefaultAnswerLabelText="Security Answer:";
	public const string CreateUserWizard_DefaultEmailRegularExpressionErrorMessage="Please enter a different e-mail.";
	public const string CreateUserWizard_DefaultCompleteSuccessText="Your account has been successfully created.";
	public const string CreateUserWizard_DefaultCreateUserTitleText="Sign Up for Your New Account";
	public const string CreateUserWizard_DefaultUserNameLabelText="User Name:";
	public const string CreateUserWizard_DefaultUserNameRequiredErrorMessage="User Name is required.";
	public const string CreateUserWizard_DefaultAnswerRequiredErrorMessage="Security answer is required.";
	public const string CreateUserWizard_DefaultEmailRequiredErrorMessage="E-mail is required.";
	public const string CreateUserWizard_DefaultQuestionRequiredErrorMessage="Security question is required.";
	public const string CreateUserWizard_DuplicateEmailErrorMessage="Text to be shown when a duplicate e-mail error is returned from create user.";
	public const string CreateUserWizard_DuplicateUserNameErrorMessage="Text to be shown when a duplicate username error is returned from create user.";
	public const string CreateUserWizard_EditProfileText="The text to be shown for the edit link.";
	public const string CreateUserWizard_EditProfileUrl="The URL of the edit profile page.";
	public const string CreateUserWizard_Email="The text to be shown in the initial textbox for e-mail.";
	public const string CreateUserWizard_EmailRegularExpression="Regular expression specification for valid e-mail addresses.";
	public const string CreateUserWizard_EmailRegularExpressionErrorMessage="The text to be shown in the validation summary when the e-mail does not match the regular expression.";
	public const string CreateUserWizard_InvalidEmailErrorMessage="The text to be shown when the e-mail is invalid.";
	public const string CreateUserWizard_EmailLabelText="The text that identifies the e-mail textbox.";
	public const string CreateUserWizard_UnknownErrorMessage="The text that is displayed for unknown errors.";
	public const string CreateUserWizard_CompleteStep="The complete WizardStep.";
	//CreateUserWizard_CompleteTitleText="The text for the complete step title.
	public const string CreateUserWizard_DisableCreatedUser="Determines if the newly created user will be disabled.";
	public const string CreateUserWizard_LoginCreatedUser="Determines if the newly created user will be logged into the site.";
	public const string CreateUserWizard_QuestionAndAnswerRequired="Determines whether a security question and answer is required to create the user.";
	public const string CreateUserWizard_RequireEmail="Determines whether an e-mail address is required to create the user.";
	public const string CreateUserWizard_ErrorMessageStyle="The style of the error message.";
	public const string CreateUserWizard_PasswordHintStyle="The style of the password hint text.";
	public const string CreateUserWizard_MailDefinition="The content and format of the e-mail message that contains the create user notification.";
	public const string CreateUserWizard_InvalidPasswordErrorMessage="The text to be shown when the password is invalid.";
	public const string CreateUserWizard_PasswordRegularExpression="Regular expression specification for valid new passwords.";
	public const string CreateUserWizard_PasswordRegularExpressionErrorMessage="The text to be shown in the validation summary when the password does not match the regular expression.";
	public const string CreateUserWizard_PasswordRequiredErrorMessage="The text to be shown in the validation summary when the password is empty.";
	public const string CreateUserWizard_NoPasswordTextBox="{0}: CreateUserWizardStep.ContentTemplate does not contain an IEditableTextControl with ID {1} for the new password, this is required if AutoGeneratePassword =" true.";
	public const string CreateUserWizard_NoUserNameTextBox="{0}: CreateUserWizardStep.ContentTemplate does not contain an IEditableTextControl with ID {1} for the username.";
	public const string CreateUserWizard_NoEmailTextBox="{0}: CreateUserWizardStep.ContentTemplate does not contain an IEditableTextControl with ID {1} for the e-mail, this is required if RequireEmail =" true.";
	public const string CreateUserWizard_NoQuestionTextBox="{0}: CreateUserWizardStep.ContentTemplate does not contain an IEditableTextControl with ID {1} for the security question, this is required if your membership provider requires a question and answer.";
	public const string CreateUserWizard_NoAnswerTextBox="{0}: CreateUserWizardStep.ContentTemplate does not contain an IEditableTextControl with ID {1} for the security answer, this is required if your membership provider requires a question and answer.";
	public const string CreateUserWizard_Question="The initial value in the question textbox.";
	public const string CreateUserWizard_InvalidQuestionErrorMessage="Text to be shown when the security question is invalid.";
	public const string CreateUserWizard_QuestionLabelText="The text that identifies the question textbox.";
	public const string CreateUserWizard_QuestionRequiredErrorMessage="The text to be shown in the validation summary when the question is empty.";
	public const string CreateUserWizard_EmailRequiredErrorMessage="The text to be shown in the validation summary when the e-mail is empty.";

	public const string CreateUserWizard_SendMailError="Raised when there is an error sending mail.";
	public const string CreateUserWizard_SideBar_Label_Not_Found="{0} control must contain a Label with ID {1} in its ItemTemplate.";
	public const string CreateUserWizard_CompleteSuccessTextStyle="The style of the complete success text.";

	public const string CreateUserWizard_DuplicateCreateUserWizardStep="There can only be one CreateUserWizardStep in your WizardSteps.";
	public const string CreateUserWizard_DuplicateCompleteWizardStep="There can only be one CompleteWizardStep in your WizardSteps.";
	public const string CreateUserWizard_ValidatorTextStyle="The style of the validators' text.";
	public const string TemplatedWizardStep_ContentTemplate="The content template for the wizard step.";
	public const string TemplatedWizardStep_CustomNavigationTemplate="The custom navigation template for the wizard step.";
	public const string CreateUserWizardStep_AllowReturnCannotBeSet="AllowReturn cannot be set.";
	public const string CreateUserWizardStep_StepTypeCannotBeSet="StepType cannot be changed.";
	public const string CreateUserWizardStep_OnlyAllowedInCreateUserWizard="CreateUserWizardStep is only allowed in a CreateUserWizard control.";
	public const string CompleteWizardStep_OnlyAllowedInCreateUserWizard="CompleteWizardStep is only allowed in a CreateUserWizard control.";
	public const string CustomValidator_ClientValidationFunction="Client script validation function.";
	public const string CustomValidator_ValidateEmptyText="Whether the validator validates the control when the text of the control is empty.";
	public const string CustomValidator_ServerValidate="Called to perform validation on the server.";
	public const string BaseDataBoundControl_DataSourceID="The control ID of an IDataSource that will be used as the data source.";
	public const string BaseDataBoundControl_DataSource="The data source that is used to populate the items in the list.";
	public const string BaseDataBoundControl_OnDataBound="Fires after the control has been databound.";
	public const string DataBoundControl_DataMember="The table or view used for binding against.";
	public const string DataBoundControl_EnableModelValidation="Whether page validation will be performed after validation is done in the model.";
	public const string DataBoundControl_ItemType="The name of the model type used in the SelectMethod, InsertMethod, UpdateMethod, and DeleteMethod.";
	public const string DataBoundControl_SelectMethod="The name of the method on the page that is called when this control does a select operation.";
	public const string DataBoundControl_UpdateMethod="The name of the method on the page that is called when this control does an update operation.";
	public const string DataBoundControl_InsertMethod="The name of the method on the page that is called when this control does an insert operation.";
	public const string DataBoundControl_DeleteMethod="The name of the method on the page that is called when this control does a delete operation.";
	public const string DataControlField_AccessibleHeaderText="The text rendered by some controls as the abbreviated text within the header of this field.";
	public const string DataControlField_ControlStyle="The style applied to each control within this field.";
	public const string DataControlField_FooterStyle="The style applied to footer within this field.";
	public const string DataControlField_FooterText="The text within the footer of this field.";
	public const string DataControlField_HeaderImageUrl="The URL of the image to be displayed in the header of this field.";
	public const string DataControlField_HeaderStyle="The style applied to header within this field.";
	public const string DataControlField_HeaderText="The text within the header of this field.";
	public const string DataControlField_InsertVisible="Whether the field is present when in Insert mode.";
	public const string DataControlField_ItemStyle="The style applied to rows within this field.";
	public const string DataControlField_ShowHeader="Whether the field's HeaderText is visible.  This property is used to control layout by some controls.";
	public const string DataControlField_SortExpression="The sort expression associated with the field.";
	public const string DataControlField_Visible="Whether the field is visible or not.";
	public const string DataGrid_AllowCustomPaging="Whether to turn on support for custom paging.";
	public const string DataGrid_AllowPaging="Whether to turn on paging functionality in the DataGrid.";
	public const string DataGrid_AllowSorting="Whether the column headers can be used to sort the associated data source.";
	public const string DataGrid_AlternatingItemStyle="The style applied to alternating items.";
	public const string DataGrid_CurrentPageIndex="The index of the current page.";
	//DataGrid_DetailTitleStyle="The style used for the mobile details view.
	public const string DataGrid_EditItemIndex="The index of the item shown in edit mode.";
	public const string DataGrid_EditItemStyle="The style applied to items in edit mode.";
	public const string DataGrid_ItemStyle="The style applied to items.";
	public const string DataGrid_Items="The collection of items.";
	//DataGrid_NextRow="Next Row
	public const string DataGrid_PageCount="The current page count.";
	public const string DataGrid_PagerStyle="Controls the paging UI associated with the control.";
	public const string DataGrid_PageSize="The number of items from the data source to display per page.";
	//DataGrid_PreviousRow="Previous Row
	public const string DataGrid_SelectedItem="The currently selected item.";
	public const string DataGrid_SelectedItemStyle="The style applied to selected items.";
	public const string DataGrid_OnCancelCommand="Fires when a Cancel CommandEvent is generated within the DataGrid.";
	public const string DataGrid_OnDeleteCommand="Fires when a Delete CommandEvent is generated within the DataGrid.";
	public const string DataGrid_OnEditCommand="Fires when an Edit CommandEvent is generated within the DataGrid.";
	public const string DataGrid_OnItemCommand="Fires when an event is generated within the DataGrid.";
	public const string DataGrid_OnPageIndexChanged="Fires when the current page index of the DataGrid has changed.";
	public const string DataGrid_OnSortCommand="Fires when a Sort CommandEvent is generated within the DataGrid.";
	public const string DataGrid_OnUpdateCommand="Fires when an Update CommandEvent is generated within the DataGrid.";
	public const string DataGrid_VisibleItemCount="The count of visible items.";
	public const string DataGridColumn_FooterStyle="The style applied to footer within this column.";
	public const string DataGridColumn_FooterText="The text within the footer of this column.";
	public const string DataGridColumn_HeaderImageUrl="The URL of the image to be displayed in the header of this column.";
	public const string DataGridColumn_HeaderStyle="The style applied to header within this column.";
	public const string DataGridColumn_HeaderText="The text within the header of this column.";
	public const string DataGridColumn_ItemStyle="The style applied to rows within this column.";
	public const string DataGridColumn_SortExpression="The sort expression associated with the column.";
	public const string DataGridColumn_Visible="Whether the column is visible or not.";
	public const string DataGridPagerStyle_Mode="The type of paging UI to use.";
	public const string DataGridPagerStyle_PageButtonCount="Number of pages to show in the paging UI.";
	public const string DataGridPagerStyle_Position="The position of the navigation bar.";
	public const string DataGridPagerStyle_Visible="Whether the paging UI is visible.";
	public const string DataList_AlternatingItemStyle="The style applied to alternating items.";
	public const string DataList_AlternatingItemTemplate="The template used for alternating items.";
	public const string DataList_EditItemIndex="The index of the item shown in edit mode.";
	public const string DataList_EditItemStyle="The style applied to items in edit mode.";
	public const string DataList_EditItemTemplate="The template used for items in edit mode.";
	public const string DataList_ExtractTemplateRows="Whether to extract the rows defined in the table within the template content.";
	public const string DataList_FooterTemplate="Template used for the footer.";
	public const string DataList_HeaderTemplate="Template used for the header.";
	public const string DataList_ItemStyle="The style applied to items.";
	public const string DataList_Items="The collection of items.";
	public const string DataList_ItemTemplate="The template used for items.";
	public const string DataList_RepeatColumns="The number of columns to be used for the layout.";
	public const string DataList_SelectedItemStyle="The style applied to selected items.";
	public const string DataList_SelectedItem="The currently selected item.";
	public const string DataList_SelectedItemTemplate="The template used for the currently selected item.";
	public const string DataList_SeparatorStyle="The style applied to separator items.";
	public const string DataList_SeparatorTemplate="The template used for separator items.";
	public const string DataList_OnCancelCommand="Fires when a Cancel CommandEvent is generated within the DataList.";
	public const string DataList_OnDeleteCommand="Fires when a Delete CommandEvent is generated within the DataList.";
	public const string DataList_OnEditCommand="Fires when an Edit CommandEvent is generated within the DataList.";
	public const string DataList_OnItemCommand="Fires when a CommandEvent is generated within the DataList.";
	public const string DataList_OnUpdateCommand="Fires when an Update CommandEvent is generated within the DataList.";
	public const string DetailsView_AllowPaging="Whether to turn on paging functionality in the DetailsView.";
	public const string DetailsView_AlternatingRowStyle="The style applied to alternating rows.";
	public const string DetailsView_AutoGenerateDeleteButton="Whether a delete button is generated automatically at runtime.";
	public const string DetailsView_AutoGenerateEditButton="Whether an edit button is generated automatically at runtime.";
	public const string DetailsView_AutoGenerateInsertButton="Whether an insert button is generated automatically at runtime.";
	public const string DetailsView_AutoGenerateRows="Whether the rows are generated automatically at runtime based on the associated data source.";
	public const string DetailsView_CellPadding="The padding within cells.";
	public const string DetailsView_CellSpacing="The spacing between cells.";
	public const string DetailsView_CommandRowStyle="The style applied to rows that contain command fields.";
	public const string DetailsView_DataKey="The Data key of the currently displayed item.";
	public const string DetailsView_PageIndex="The index of the current data item being displayed by the control.";
	public const string DetailsView_EnablePagingCallbacks="Whether client script for paging should be rendered to browser clients that can support callbacks.";
	public const string DetailsView_FooterStyle="The style applied to the footer.";
	public const string DetailsView_FooterTemplate="The template used for the footer.";
	public const string DetailsView_FieldHeaderStyle="The style applied to the header column.";
	public const string DetailsView_OnPageIndexChanged="Fires when the page index of the DetailsView has changed.";
	public const string DetailsView_OnPageIndexChanging="Fires when the page index of the DetailsView is changing.";
	public const string DetailsView_OnItemCommand="Fires when a CommandEvent is generated within the DetailsView.";
	public const string DetailsView_OnItemCreated="Fires when the item is created.";
	public const string DetailsView_OnModeChanged="Fires after the DetailsView's mode changes.";
	public const string DetailsView_OnModeChanging="Fires before the DetailsView's mode changes.";
	public const string DetailsView_PagerSettings="Controls the paging UI settings associated with the control.";
	public const string DetailsView_Fields="The set of fields to be shown in the control.";
	public const string DetailsView_Rows="The collection of rows.";

	public const string FontInfo_Name="The preferred font to be used to render the control.";
	public const string FontInfo_Names="Sequence of fonts that can be used to render the control.";
	public const string FontInfo_Size="The size of the font.";
	public const string FontInfo_Bold="Whether the font is bold.";
	public const string FontInfo_Italic="Whether the font is italic.";
	public const string FontInfo_Underline="Whether the font is underlined.";
	public const string FontInfo_Strikeout="Whether the font has a strike through it.";
	public const string FontInfo_Overline="Whether the font contains an overline.";
	public const string FormView_AllowPaging="Whether to turn on paging functionality in the FormView.";
	public const string FormView_CellPadding="The padding within cells.";
	public const string FormView_CellSpacing="The spacing between cells.";
	public const string FormView_DataKey="The Data key of the currently displayed item.";
	public const string FormView_PageIndex="The index of the current page being displayed by the control.";
	public const string FormView_EditItemTemplate="The template used when the control is in edit mode.";
	public const string FormView_RenderOuterTable="Whether to render a table around the templates in the FormView.";
	public const string FormView_FooterStyle="The style applied to the footer.";
	public const string FormView_FooterTemplate="The template used for the footer.";
	public const string FormView_InsertItemTemplate="The template used when the control is in insert mode.";
	public const string FormView_OnPageIndexChanged="Fires when the page index of the FormView has changed.";
	public const string FormView_OnPageIndexChanging="Fires when the page index of the FormView is changing.";
	public const string FormView_OnItemCommand="Fires when a CommandEvent is generated within the FormView.";
	public const string FormView_OnItemCreated="Fires when the item is created.";
	public const string FormView_OnModeChanged="Fires after the FormView's mode changes.";
	public const string FormView_OnModeChanging="Fires before the FormView's mode changes.";
	public const string FormView_Rows="The collection of rows.";

	public const string HiddenField_OnValueChanged="Fires when the value of the control changes.";
	public const string HiddenField_Value="The value stored in the hidden field.";
	public const string HotSpot_AccessKey="Keyboard shortcut used by the HotSpot.";
	public const string HotSpot_AlternateText="Tool tip to display over the hotspot.";
	public const string HotSpot_PostBackValue="The value for postback event.";
	public const string HotSpot_NavigateUrl="URL for navigation.";
	public const string HotSpot_TabIndex="The tab order of the HotSpot.";
	public const string HyperLink_ImageUrl="The URL of an image to be displayed.";
	public const string HyperLink_ImageHeight="The height of an image to be displayed.";
	public const string HyperLink_ImageWidth="The width of an image to be displayed.";
	public const string HyperLink_NavigateUrl="The URL to navigate to.";
	public const string HyperLink_Target="The target frame for the NavigateUrl.";
	public const string HyperLink_Text="The text to be shown for the link.";
	public const string HyperLinkColumn_DataNavigateUrlField="The field bound to the NavigateUrl property of the hyperlink.";
	public const string HyperLinkColumn_DataTextField="The field bound to the text property of the hyperlink.";
	public const string HyperLinkColumn_NavigateUrl="The URL navigated to by the hyperlink.";
	public const string HyperLinkColumn_Text="The text used for the hyperlink.";
	public const string HyperLinkField_DataNavigateUrlFields="The fields bound to the NavigateUrl property of the hyperlink.";
	public const string HyperLinkField_DataNavigateUrlFormatString="The formatting applied to the value bound to the NavigateUrl property of the hyperlink. For example, "page.aspx?id="{0}".";
	public const string HyperLinkField_DataTextField="The field bound to the text property of the hyperlink.";
	public const string HyperLinkField_DataTextFormatString="The formatting applied to the value bound to the Text property of the hyperlink. For example, "go back to: {0}".";
	public const string HyperLinkField_NavigateUrl="The URL navigated to by the hyperlink.";
	public const string HyperLinkField_Text="The text used for the hyperlink.";
	public const string Image_AlternateText="The alternate text displayed when the image cannot be shown.";
	public const string Image_DescriptionUrl="The URL containing a more detailed description of the image.";
	public const string Image_GenerateEmptyAlternateText="Specifies whether an empty alternate text attribute is generated when the alternate text is not specified.";
	public const string Image_ImageAlign="The alignment of the image.";
	public const string Image_ImageUrl="The URL of the image to be shown.";
	public const string ImageButton_OnClick="Fires when the image is clicked.";
	public const string ImageButton_OnCommand="Fires when the image is clicked and an associated command is defined.";
	//ImageButton_SoftkeyLabel="The label shown when the ImageButton is mapped to a mobile device softkey.
	public const string ImageField_AlternateText="The value of the AlternateText property of the image.";
	public const string ImageField_DataAlternateTextField="The field bound to the AlternateText property of the image.";
	public const string ImageField_DataAlternateTextFormatString="The formatting applied to the value bound to the AlternateText property of the image when using the DataAlternateTextField. For example, "image: {0}".";
	public const string ImageField_ConvertEmptyStringToNull="Whether the field treats empty strings as null when the value is extracted from the field.";
	public const string ImageField_ImageUrlField="The field to which the image URL is bound.";
	public const string ImageField_ImageUrlFormatString="The formatting applied to the value bound to the ImageUrl property of the image.";
	public const string ImageField_NullImageUrl="The URL of the image displayed if the data bound to the field is null.";
	public const string ImageField_ReadOnly="Whether the field does not permit editing of its image field.";
	public const string ImageMap_Click="Fires when a hotspot is clicked.";
	public const string ImageMap_HotSpots="The hotspots collection.";
	public const string IRenderOuterTableControl_CannotSetStyleWhenDisableRenderOuterTable="The style property '{0}' cannot be used while RenderOuterTable is disabled on the {1} control with ID '{2}'.";
	public const string Label_AssociatedControlID="The ID of the control associated with the Label.";
	public const string Label_Text="The text to be shown for the Label.";
	public const string Literal_Text="The text to be shown for the literal.";
	public const string Literal_Mode="Determines whether the text is transformed or encoded.";
	//LinkButton_SoftkeyLabel="The label shown when the LinkButton is mapped to a mobile device softkey.
	public const string LinkButton_Text="The text to be shown for the link.";
	public const string LinkButton_OnClick="Fires when the button is clicked.";
	public const string ListBox_Rows="The number of visible rows to display.";
	public const string ListBox_SelectionMode="The selection mode for the list.";
	public const string ListControl_AppendDataBoundItems="Append data bound items to statically declared list items.";
	public const string ListControl_AutoPostBack="Automatically postback to the server after selection is changed.";
	public const string ListControl_DataTextField="The field in the data source which provides the item text.";
	public const string ListControl_DataTextFormatString="The formatting applied to the text field. For example, "{0:d}".";
	public const string ListControl_DataValueField="The field in the data source which provides the item value.";
	public const string ListControl_Items="The collection of items in the list.";
	public const string ListControl_SelectedItem="The currently selected item.";
	public const string ListControl_SelectedValue="The value of the currently selected item.";
	public const string ListControl_OnSelectedIndexChanged="Fires when the selected index has been changed.";
	public const string ListControl_Text="The text value.";
	public const string ListControl_TextChanged="Fires when the text property has been changed.";
	public const string Login_LoggedIn="Raised after the user is authenticated.";
	public const string Login_Authenticate="Raised to authenticate the user.";
	public const string Login_LoggingIn="Raised before the user is authenticated.";
	public const string Login_CheckBoxStyle="The style of the checkbox.";
	public const string Login_CreateUserUrl="The URL of the create user page.";
	public const string Login_CreateUserIconUrl="The URL of an icon for the create user link.";
	public const string Login_DefaultFailureText="Your login attempt was not successful. Please try again.";
	public const string LoginControls_DefaultPasswordLabelText="Password:";
	public const string Login_DefaultPasswordRequiredErrorMessage="Password is required.";
	public const string Login_DefaultRememberMeText="Remember me next time.";
	public const string Login_DefaultLoginButtonText="Log In";
	public const string Login_DefaultTitleText="Log In";
	public const string Login_DefaultUserNameLabelText="User Name:";
	public const string Login_DefaultUserNameRequiredErrorMessage="User Name is required.";
	public const string Login_DestinationPageUrl="The URL that the user is directed to upon successful login.";
	public const string Login_DisplayRememberMe="True if the remember me checkbox is displayed.";
	public const string Login_HelpPageIconUrl="The URL of an icon for the help page link.";
	public const string Login_InvalidBorderPadding="BorderPadding must be greater than or equal to -1.";
	public const string Login_LoginError="Raised if the authentication fails.";
	public const string Login_FailureAction="The action to take when a login attempt fails.";
	public const string Login_FailureText="The text to be shown when a login attempt fails.";
	public const string Login_Orientation="The general layout of the control.";
	public const string Login_NoPasswordTextBox="{0}: LayoutTemplate does not contain an IEditableTextControl with ID {1} for the password.";
	public const string Login_NoUserNameTextBox="{0}: LayoutTemplate does not contain an IEditableTextControl with ID {1} for the username.";
	public const string LoginControls_PasswordLabelText="The text that identifies the password textbox.";
	public const string Login_PasswordRecoveryUrl="The URL of the password recovery page.";
	public const string Login_PasswordRecoveryIconUrl="The URL of an icon for the password recovery link.";
	public const string Login_PasswordRequiredErrorMessage="The text to be shown in the validation summary when the password is empty.";
	public const string Login_RememberMeSet="Whether the remember me checkbox is initially checked.";
	public const string Login_RememberMeText="The text to be shown for the remember me checkbox.";
	public const string LoginControls_RenderOuterTable="Whether to render a table around the templates in this control.";
	public const string Login_LoginButtonImageUrl="The URL of an image to be displayed for the login button.";
	public const string Login_LoginButtonStyle="The style of the login button.";
	public const string Login_LoginButtonType="The type of the login button.";
	public const string Login_LoginButtonText="The text to be shown for the login button.";
	public const string Login_BorderPadding="The padding from the border of the control.";
	//Login_BorderSpacing="The spacing from the border of the control.
	public const string Login_ValidatorTextStyle="The style of the validators' text.";
	public const string Login_VisibleWhenLoggedIn="True if the control remains visible when a user is logged in.";
	public const string LoginName_InvalidFormatString="FormatString is not a valid format string.";
	public const string LoginName_FormatString="The format specification.  {0} is replaced with the user name of the logged in user.";
	public const string LoginName_DesignModeUserName="[UserName]";
	public const string LoginStatus_LoginImageUrl="The URL of the image to be shown for the login button.";
	public const string LoginStatus_LoginText="The text to be shown for the login button.";
	public const string LoginStatus_LogoutAction="The action to perform after logging out.";
	public const string LoginStatus_LogoutImageUrl="The URL of the image to be shown for the logout button.";
	public const string LoginStatus_LogoutPageUrl="The URL redirected to after logging out.";
	public const string LoginStatus_LogoutText="The text to be shown for the logout button.";
	public const string LoginStatus_LoggedOut="Raised after the user is logged out.";
	public const string LoginStatus_LoggingOut="Raised before the user is logged out.";
	public const string LoginStatus_DefaultLoginText="Login";
	public const string LoginStatus_DefaultLogoutText="Logout";
	public const string LoginView_RoleGroups="Associates templates with roles.";
	public const string LoginView_ViewChanged="Raised after the view is changed.";
	public const string LoginView_ViewChanging="Raised before the view is changed.";
	public const string EmbeddedMailObject_Name="The name of the embedded mail object.";
	public const string EmbeddedMailObject_Path="The absolute path to the embedded mail object file.";
	public const string MailDefinition_EmbeddedObjects="Embedded objects within the e-mail message.";
	public const string MailDefinition_BodyFileName="The file that contains the body of the e-mail message.";
	public const string MailDefinition_CC="A comma-delimited list of e-mail addresses that receive a carbon copy (CC) of the e-mail message.";
	public const string MailDefinition_From="The sender's e-mail address.";
	public const string MailDefinition_InvalidReplacements="The replacements dictionary must contain only strings.";
	public const string MailDefinition_IsBodyHtml="True if the body is html;";
	public const string MailDefinition_NoFromAddressSpecified="A from e-mail address must be specified in the From property or the system.net/mailSettings/smtp config section.";
	public const string MailDefinition_Priority="The priority of the e-mail message.";
	public const string MailDefinition_Subject="The subject line of the e-mail message.";
	public const string MenuItemStyle_HorizontalPadding="The amount of horizontal padding around the item text.";
	public const string MenuItemStyle_ItemSpacing="The amount of vertical spacing between items.";
	public const string MenuItemStyle_VerticalPadding="The amount of vertical padding around the item text.";
	public const string MenuItemStyleCollection_InvalidArgument="MenuItemStyleCollection can only contain MenuItemStyles.";
	public const string MenuItemBinding_Depth="The menu depth associated with the menu level object.";
	public const string MenuItemBinding_Enabled="The default value for the Enabled property for all menu items in this level when databinding.";
	public const string MenuItemBinding_EnabledField="The table column or XML attribute name to use for the menu item's Enabled property when databinding.";
	public const string MenuItemBinding_FormatString="The format string to use when formatting the value retrieved from TextField, for example: "Item {0}".";
	public const string MenuItemBinding_ImageUrl="The default image URL for all menu items in this level when databinding.";
	public const string MenuItemBinding_ImageUrlField="The table column or XML attribute name to use for the menu item's ImageUrl property when databinding.";
	public const string MenuItemBinding_NavigateUrl="The default navigation URL for all menu items in this level when databinding.";
	public const string MenuItemBinding_NavigateUrlField="The table column or XML attribute name to use for the menu item's NavigateUrl property when databinding.";
	public const string MenuItemBinding_PopOutImageUrl="The default pop-out image URL for all menu items in this level when databinding.";
	public const string MenuItemBinding_PopOutImageUrlField="The table column or XML attribute name to use for the menu item's PopOutImageUrl property when databinding.";
	public const string MenuItemBinding_Selectable="The default value for the Selectable property for all menu items in this level when databinding.";
	public const string MenuItemBinding_SelectableField="The table column or XML attribute name to use for the menu item's Selectable property when databinding.";
	public const string MenuItemBinding_SeparatorImageUrl="The default separator image URL for all menu items in this level when databinding.";
	public const string MenuItemBinding_SeparatorImageUrlField="The table column or XML attribute name to use for the menu item's SeparatorImageUrl property when databinding.";
	public const string MenuItemBinding_Target="The default navigation target for all menu items in this level when databinding.";
	public const string MenuItemBinding_TargetField="The table column or XML attribute name to use for the menu item's Target property when databinding.";
	public const string MenuItemBinding_Text="The default text for all menu items in this level when databinding.";
	public const string MenuItemBinding_TextField="The table column or XML attribute name to use for a menu item's Text property when databinding.";
	public const string MenuItemBinding_ToolTip="The default tooltip for all menu items in this level when databinding.";
	public const string MenuItemBinding_ToolTipField="The table column or XML attribute name to use for the menu item's ToolTip property when databinding.";
	public const string MenuItemBinding_Value="The default value for all menu items in this level when databinding.";
	public const string MenuItemBinding_ValueField="The table column or XML attribute name to use for a menu item's Value property when databinding. When binding to a data source, this is usually a unique key in the current level view.";
	public const string MenuItem_Enabled="Enabled state of the menu item.";
	public const string MenuItem_ImageUrl="The URL for the image for the menu item.";
	public const string MenuItem_NavigateUrl="The URL to which the menu item navigates when selected.";
	public const string MenuItem_PopOutImageUrl="The URL for the image that shows if the menu item has children.";
	public const string MenuItem_Selectable="If false, the menu item can't be selected, but its child menu items are still accessible.";
	public const string MenuItem_Selected="The select state of the menu item.";
	public const string MenuItem_SeparatorImageUrl="The URL for the image that will be used as a separator.";
	public const string MenuItem_Target="The navigate target used when the menu item is selected.";
	public const string MenuItem_Text="The display text of the menu item.";
	public const string MenuItem_ToolTip="The tooltip of the menu item.";
	public const string MenuItem_Value="The value of the menu item.";
	public const string MenuItemCollection_InvalidArrayType="MenuItem[] expected.";
	public const string Menu_Bindings="The data bindings for menu items in the menu.";
	public const string Menu_CannotChangeRenderingMode="The RenderingMode property cannot be changed once rendering or pre-rendering begins.";
	public const string Menu_DataSourceReturnedNullView="The IHierarchicalDataSource that is the data source for Menu '{0}' returned a null view for the given view path.";
	public const string Menu_DesignTimeDummyItemText="Menu Item";
	public const string Menu_DisappearAfter="The time (in milliseconds) after which the popped-out menus will disappear.";
	public const string Menu_DynamicBottomSeparatorImageUrl="The URL of the image that will serve as a bottom separator in the dynamic part of the menu.";
	public const string Menu_DynamicDisplayPopOutImage="Determines if the default pop-out image is displayed in the dynamic part of the menu.";
	public const string Menu_DynamicHorizontalOffset="The horizontal offset in pixels between the right border of a menu item and the left border of its sub-menu.";
	public const string Menu_DynamicHoverStyle="The style that gets applied when the mouse hovers over an item in the dynamic part of the menu (only available when client script is enabled).";
	public const string Menu_DynamicItemFormatString="The format string that gets applied to the dynamic item texts, for example "Item {0}".";
	public const string Menu_DynamicMenuItemStyle="The style of menu items that are in the dynamic part of the menu.";
	public const string Menu_DynamicMenuStyle="The style of submenus in the dynamic part.";
	public const string Menu_DynamicPopoutImageUrl="The URL of the image that will show that an item has a sub-menu in the dynamic part of the menu.";
	public const string Menu_DynamicPopoutImageText="The alternate text for the pop-out image in the dynamic part of the menu.";
	public const string Menu_DynamicSelectedStyle="The style applied to the selected item if in the dynamic part of the menu.";
	public const string Menu_DynamicTemplate="The template for dynamic menu items.";
	public const string Menu_DynamicTopSeparatorImageUrl="The URL of the image that will serve as a top separator in the dynamic part of the menu.";
	public const string Menu_DynamicVerticalOffset="The vertical offset in pixels between the top of a menu item and the top of its sub-menu.";
	//Menu_ExpandImageUrl="The URL to the image that expands an item when hovered over.
	//Menu_HideSelectElements="When set to false, the menu won't hide the Select elements on the page when displaying pop-out menus. The Select elements may then appear above the pop-out menus.
	public const string Menu_IncludeStyleBlock="Determines whether or not to render the inline style block (only used in standards compliance mode)";
	public const string Menu_InvalidDataBinding="Could not bind to the '{0}' property (specified by {1}) while databinding Menu.  Please check the Bindings fields.";
	public const string Menu_InvalidDepth="The depth of the selected item is larger than StaticDisplayLevels + MaximumDynamicDisplayLevels. This could be caused by an invalid declaration, by a change since the last request or by a forged request.";
	public const string Menu_InvalidNavigation="Can't open a disabled menu item.";
	public const string Menu_InvalidSelection="Can't select a disabled or unselectable menu item.";
	public const string Menu_Items="The collection of items in the menu.";
	public const string Menu_ItemWrap="Whether the item text should be word wrapped.";
	public const string Menu_LevelMenuItemStyles="The menu item styles to be applied at each level of the menu.";
	public const string Menu_LevelSelectedStyles="The selected menu item styles to be applied at each level of the menu.";
	public const string Menu_LevelSubMenuStyles="The sub-menu styles to be applied at each level of the menu.";
	public const string Menu_MaximumDynamicDisplayLevels="The maximum number of pop-outs supported by the menu.";
	public const string Menu_MaximumDynamicDisplayLevelsInvalid="MaximumDynamicDisplayLevels must be a positive integer.";
	public const string Menu_MenuItemClick="Fired after an item has been clicked.";
	public const string Menu_MenuItemDataBound="Fired after a MenuItem is databound.";
	public const string Menu_Orientation="Whether the static part of the menu should be rendered horizontally or vertically.";
	public const string Menu_PathSeparator="The character used to separate parts of the path.";
	public const string Menu_RenderingMode="Whether to render the menu with tables or unordered lists.";
	public const string Menu_ScrollDown="Scroll down";
	public const string Menu_ScrollDownImageUrl="The URL of the image that will enable scrolling down in sub-menus.";
	public const string Menu_ScrollDownText="The tooltip text for the scroll-down button in sub-menus.";
	public const string Menu_ScrollUpImageUrl="The URL of the image that will enable scrolling up in sub-menus.";
	public const string Menu_SkipLinkTextDefault="Skip Navigation Links";
	public const string Menu_ScrollUp="Scroll up";
	public const string Menu_ScrollUpText="The tooltip text for the scroll-up button in sub-menus.";
	public const string Menu_StaticBottomSeparatorImageUrl="The URL of the image that will serve as a bottom separator in the static part of the menu.";
	public const string Menu_StaticDisplayLevels="The number of levels displayed in the static part of the menu.";
	public const string Menu_StaticDisplayPopOutImage="Determines if the default pop-out image is displayed in the static part of the menu.";
	public const string Menu_StaticHoverStyle="The style that gets applied when the mouse hovers over an item in the static part of the menu (only available when client script is enabled).";
	public const string Menu_StaticItemFormatString="The format string that gets applied to the static item texts, for example "Item {0}".";
	public const string Menu_StaticMenuItemStyle="The style of menu items that are in the static part of the menu.";
	public const string Menu_StaticMenuStyle="The style of the static part of the menu.";
	public const string Menu_StaticPopoutImageText="The alternate text for the pop-out image in the static part of the menu.";
	public const string Menu_StaticPopoutImageUrl="The URL of the image that will show that an item has a sub-menu in the static part of the menu.";
	public const string Menu_StaticSelectedStyle="The style applied to the selected item if in the static part of the menu.";
	public const string Menu_StaticSubMenuIndent="The indentation between a static menu item and its static sub-menu.";
	public const string Menu_StaticTemplate="The template for static menu items.";
	public const string Menu_StaticTopSeparatorImageUrl="The URL of the image that will serve as a top separator in the static part of the menu.";
	public const string ModelErrorMessage_AssociatedControlID="The ID of the control associated with the model state error message.";
	public const string ModelErrorMessage_ModelStateKey="The key of the model state value to display the first error for.";
	public const string ModelErrorMessage_SetFocusOnError="Whether focus is set on the associated control when a model state error message is found.";
	public const string MultiView_ActiveView="The active View control.";
	public const string MultiView_ActiveViewChanged="Fires when the active view control is changed.";
	public const string MultiView_ActiveViewIndex_out_of_range="The ActiveViewIndex must be less than Views.Count and at least -1.";
	public const string MultiView_cannot_have_children_of_type="MultiView cannot have children of type '{0}'.  It can only have children of type View.";
	public const string Multiview_rendering_block_not_allowed="A rendering block cannot be nested inside a MultiView control.";
	public const string MultiView_Views="The collection of Views.";
	public const string MultiView_invalid_view_id="MultiView with id '{0}' could not find a View '{1}' specified in CommandArgument with CommandName '{2}'.";
	public const string MultiView_invalid_view_index_format="CommandArgument '{0}' with CommandName '{1}' is not a valid integer for ActiveViewIndex.";
	public const string MultiView_view_not_found="The view {0} cannot be found inside {1}, the ActiveView must be a View control directly inside a MultiView.";
	public const string MultiView_ActiveViewIndex_less_than_minus_one="ActiveViewIndex is being set to '{0}'.  It cannot be less than -1.";
	public const string MultiView_ActiveViewIndex_equal_or_greater_than_count="ActiveViewIndex is being set to '{0}'.  It must be smaller than the current number of View controls '{1}'. For dynamically added views, make sure they are added before or in Page_PreInit event.";
	public const string View_CannotSetVisible="The Visible property of a View control can only be set by setting the active View of a MultiView.";
	public const string SiteMapPath_CannotFindUrl="Could not find the sitemap node with URL '{0}'.";
	public const string SiteMapPath_CurrentNodeStyle="The style applied to current node.";
	public const string SiteMapPath_CurrentNodeTemplate="The template used for the current node.";
	//SiteMapPath_HoverStyle="The style applied for mouse hover.
	public const string SiteMapPath_OnItemDataBound="Fires when an item is databound.";
	public const string SiteMapPath_NodeStyle="The style applied to navigation nodes.";
	public const string SiteMapPath_NodeTemplate="The template used for the navigation nodes.";
	public const string SiteMapPath_PathDirection="The direction of path to render.";
	public const string SiteMapPath_PathSeparator="The separator string between each node.";
	public const string SiteMapPath_PathSeparatorTemplate="The template used for the path separators.";
	public const string SiteMapPath_PathSeparatorStyle="The style applied to the path separators.";
	public const string SiteMapPath_Provider="The SitemapProvider used by this control.";
	public const string SiteMapPath_RenderCurrentNodeAsLink="Indicates whether the current node will be rendered as a link.";
	public const string SiteMapPath_RootNodeStyle="The style applied to root node.";
	public const string SiteMapPath_RootNodeTemplate="The template used for the root node.";
	public const string SiteMapPath_SiteMapProvider="The name of the sitemap provider.";
	public const string SiteMapPath_SkipToContentText="The text that appears in the ALT attribute of the invisible image link that allows screen readers to skip repetitive content.";
	public const string SiteMapPath_Default_SkipToContentText="Skip Navigation Links";
	public const string SiteMapPath_ShowToolTips="Indicates whether tooltip will be shown.";
	public const string SiteMapPath_ParentLevelsDisplayed="The number of parent nodes to display.";
	public const string SubMenuStyle_HorizontalPadding="The amount of horizontal padding around the items.";
	public const string SubMenuStyle_VerticalPadding="The amount of vertical padding around the items.";
	public const string SubMenuStyleCollection_InvalidArgument="SubMenuStyleCollection can only contain SubMenuStyles.";
	public const string Panel_BackImageUrl="The background image of the panel.";
	public const string Panel_DefaultButton="The default button for the panel.";
	public const string Panel_Direction="The direction of text in the panel.";
	public const string Panel_GroupingText="The text of group box around this control's contents.";
	public const string Panel_HorizontalAlign="The horizontal alignment of the content.";
	public const string Panel_ScrollBars="The appearance of scrollbars for the panel.";
	public const string Panel_Wrap="Whether the content should wrap or not.";
	public const string PasswordRecovery_AnswerLabelText="The text that identifies the answer textbox.";
	public const string PasswordRecovery_AnswerLookupError="Raised when the answer provided is incorrect.";
	public const string PasswordRecovery_VerifyingAnswer="Raised before the answer is validated.";
	public const string PasswordRecovery_SendingMail="Raised before the e-mail is sent.";
	public const string PasswordRecovery_VerifyingUser="Raised before the username is looked up.";
	public const string PasswordRecovery_DefaultAnswerLabelText="Answer:";
	public const string PasswordRecovery_DefaultAnswerRequiredErrorMessage="Answer is required.";
	public const string PasswordRecovery_DefaultBody="Please return to the site and log in using the following information.\nUser Name: <%UserName%>\nPassword: <%Password%>\n\n";
	public const string PasswordRecovery_DefaultGeneralFailureText="Your attempt to retrieve your password was not successful. Please try again.";
	public const string PasswordRecovery_DefaultUserNameFailureText="We were unable to access your information. Please try again.";
	public const string PasswordRecovery_DefaultQuestionInstructionText="Answer the following question to receive your password.";
	public const string PasswordRecovery_DefaultQuestionFailureText="Your answer could not be verified. Please try again.";
	public const string PasswordRecovery_DefaultQuestionLabelText="Question:";
	public const string PasswordRecovery_DefaultQuestionTitleText="Identity Confirmation";
	public const string PasswordRecovery_DefaultSubject="Password";
	public const string PasswordRecovery_DefaultSubmitButtonText="Submit";
	public const string PasswordRecovery_DefaultSuccessText="Your password has been sent to you.";
	public const string PasswordRecovery_DefaultUserNameInstructionText="Enter your User Name to receive your password.";
	public const string PasswordRecovery_DefaultUserNameLabelText="User Name:";
	public const string PasswordRecovery_DefaultUserNameRequiredErrorMessage="User Name is required.";
	public const string PasswordRecovery_DefaultUserNameTitleText="Forgot Your Password?";
	//PasswordRecovery_FromNotSpecified="The sender's e-mail address must be set in the smtpMail config section, the PasswordRecovery.MailDefinition.From field, or in the SendingMail event handler.
	public const string PasswordRecovery_GeneralFailureText="The text to be shown when there is an unexpected failure.";
	public const string PasswordRecovery_InvalidBorderPadding="BorderPadding must be greater than or equal to -1.";
	public const string PasswordRecovery_MailDefinition="The content and format of the e-mail message that contains the successful recovered password notification.";
	public const string PasswordRecovery_NoUserNameTextBox="{0}: UserNameTemplate does not contain an IEditableTextControl with ID {1} for the username.";
	public const string PasswordRecovery_NoAnswerTextBox="{0}: QuestionTemplate does not contain an IEditableTextControl with ID {1} for the answer.";

	public const string PasswordRecovery_QuestionFailureText="The text to be shown when the answer is incorrect.";
	public const string PasswordRecovery_QuestionInstructionText="Text that is displayed to give instructions for answering the question.";
	public const string PasswordRecovery_QuestionLabelText="The text that identifies the question textbox.";
	public const string PasswordRecovery_QuestionTemplate="Template for the question view.";
	public const string PasswordRecovery_QuestionTemplateContainer="Container for the question view.";
	public const string PasswordRecovery_QuestionTitleText="The text to be shown for the title when answering the question.";
	public const string PasswordRecovery_RecoveryNotSupported="Membership provider does not support password retrieval or reset.";
	public const string PasswordRecovery_SubmitButtonStyle="The style of the submit button.";
	public const string PasswordRecovery_SubmitButtonType="The type of the submit button.";

	public const string PasswordRecovery_SuccessTemplate="Template for the success view.";
	public const string PasswordRecovery_SuccessTemplateContainer="Container for the success view.";
	public const string PasswordRecovery_SuccessText="The text to be shown after the password e-mail has been sent.";
	public const string PasswordRecovery_SuccessTextStyle="The style of the success text.";
	public const string PasswordRecovery_UserLookupError="Raised when the user name is invalid.";
	public const string PasswordRecovery_UserNameFailureText="The text to be shown when the user name is invalid.";
	public const string PasswordRecovery_UserNameInstructionText="Text that is displayed to give instructions for entering the user name.";
	public const string PasswordRecovery_UserNameLabelText="The text that identifies the user name textbox.";
	public const string PasswordRecovery_UserNameTemplate="Template for the username view.";
	public const string PasswordRecovery_UserNameTemplateContainer="Container for the username view.";
	public const string PasswordRecovery_UserNameTitleText="The text to be shown for the title when entering the user name.";
	//PasswordRecovery_UserNameWrongType="UserName control with ID {0} inside UserNameTemplate must be of type ITextControl.
	//PasswordRecovery_ValidatorTextStyle="The style of the validators' text.
	public const string PolygonHotSpot_Coordinates="The coordinates of the points representing the polygon.";
	public const string RadioButton_GroupName="Group that this radio button belongs to.";
	public const string RadioButtonList_CellPadding="The padding between each item.";
	public const string RadioButtonList_CellSpacing="The spacing between each item.";
	public const string RadioButtonList_RepeatColumns="The number of columns to use to lay out the items.";
	public const string RangeValidator_MaximumValue="Maximum value for the control being validated.";
	public const string RangeValidator_MinmumValue="Minimum value for the control being validated.";
	public const string RangeValidator_Type="Data type of values for comparison.";
	public const string ReadOnlyHierarchicalDataSourceView_CantAccessPathInEnumerable="Can't use a view path when the data source implements IHierarchicalEnumerable and not IHierarchicalDataSource.";
	public const string RectangleHotSpot_Bottom="The bottom coordinate of the rectangular hot spot.";
	public const string RectangleHotSpot_Right="The right coordinate of the rectangular hot spot.";
	public const string RectangleHotSpot_Top="The top coordinate of the rectangular hot spot.";
	public const string RectangleHotSpot_Left="The left coordinate of the rectangular hot spot.";
	public const string RegularExpressionValidator_ValidationExpression="Regular expression to determine validity.";
	public const string Repeater_AlternatingItemTemplate="The template used for alternating items.";
	public const string Repeater_DataMember="The table or view used for binding when a DataSet is used a data source.";
	public const string Repeater_FooterTemplate="The template used for the footer.";
	public const string Repeater_Items="The collection of items.";
	public const string Repeater_ItemTemplate="The template used for the items.";
	public const string Repeater_OnItemCommand="Fires when an event is generated within the DataList.";
	public const string Repeater_SeparatorTemplate="The template used for the separators.";

	public const string RepeatInfo_ListLayoutDoesNotSupportHeaderFooterSeparator="The UnorderedList and OrderedList layouts do not support headers, footers, or separators.";
	public const string RepeatInfo_ListLayoutOnlySupportsVerticalLayout="The UnorderedList and OrderedList layouts only support vertical layout.";
	public const string RepeatInfo_ListLayoutDoesNotSupportMultipleColumn="The UnorderedList and OrderedList layouts do not support multi-column layouts.";
	public const string RepeatInfo_ListLayoutDoesNotSupportImpliedOuterTable="The UnorderedList and OrderedList layouts do not support implied outer tables.";

	public const string RequiredFieldValidator_InitialValue="Initial value of the field to validate.";
	public const string SiteMapDataSource_Description="Connect to the site navigation tree for this application (requires a valid sitemap file at the application root).";
	public const string SiteMapDataSource_DisplayName="Site Map";
	public const string SiteMapDataSource_Provider="The SitemapProvider used by this control.";
	public const string SiteMapDataSource_ContainsListCollection="Indicates whether the data source control contains ListCollection.";
	public const string SiteMapDataSource_StartingNodeOffset="The depth at which the base node of the SiteMap starts.";
	public const string SiteMapDataSource_StartingNodeUrl="The URL of the starting node.";
	public const string SiteMapDataSource_SiteMapProvider="The name of the provider used to populate the data source control.";
	public const string SiteMapDataSource_ProviderNotFound="The SiteMapProvider '{0}' cannot be found.";
	public const string SiteMapDataSource_DefaultProviderNotFound="Default provider is not defined in your configuration files. You must specify the defaultProvider within <siteMap> section to enable sitemap feature.";
	public const string SiteMapDataSource_ShowStartingNode="Indicates whether the starting node should be returned.";
	public const string SiteMapDataSource_StartFromCurrentNode="Indicates whether to display from the current node.";
	public const string SiteMapDataSource_StartingNodeUrlAndStartFromcurrentNode_Defined="StartingNodeUrl may not be set when StartFromCurrentNode is true.";
	public const string GridView_AllowCustomPaging="Whether to turn on support for custom paging.";
	public const string GridView_AllowPaging="Whether to turn on paging functionality in the GridView.";
	public const string GridView_AllowSorting="Whether the field headers can be used to sort the associated data source.";
	public const string GridView_AlternatingRowStyle="The style applied to alternating rows.";
	public const string GridView_AutoGenerateDeleteButton="Whether the delete button is generated automatically at runtime.";
	public const string GridView_AutoGenerateEditButton="Whether the edit button is generated automatically at runtime.";
	public const string GridView_AutoGenerateSelectButton="Whether the select button is generated automatically at runtime.";
	public const string GridView_CellPadding="The padding within cells.";
	public const string GridView_CellSpacing="The spacing between cells.";
	public const string GridView_DataKeys="The collection of data key field values.";
	public const string GridView_EditIndex="The index of the row shown in edit mode.";
	public const string GridView_EditRowStyle="The style applied to rows in edit mode.";
	public const string GridView_EnableSortingAndPagingCallbacks="Whether client script for sorting and paging should be rendered to browser clients that can support callbacks.";
	public const string GridView_EnablePersistedSelection="Whether selection should be based on DataKeys or row index.";
	public const string GridView_EmptyDataRowStyle="The style applied to the row that contain the EmptyDataTemplate.";
	//GridView_NextRow="Next Row
	public const string GridView_OnRowCancelingEdit="Fires when a Cancel event is generated within the GridView.";
	public const string GridView_OnRowEditing="Fires when an Edit event is generated within the GridView.";
	public const string GridView_OnPageIndexChanging="Fires when the current page index of the GridView is changing.";
	public const string GridView_OnPageIndexChanged="Fires when the current page index of the GridView has changed.";
	public const string GridView_OnSelectedIndexChanged="Fires when a row is selected in the GridView, after the selection is complete.";
	public const string GridView_OnSelectedIndexChanging="Fires when a new row is selected in the GridView, before the new row is selected.";
	public const string GridView_OnSorted="Fires when a column is sorted in the GridView, after the sort is complete.";
	public const string GridView_OnSorting="Fires when a column is sorted in the GridView, before the sort occurs.";
	public const string GridView_OnRowCommand="Fires when an event is generated within the GridView.";
	public const string GridView_OnRowCreated="Fires when a row is created.";
	public const string GridView_OnRowDataBound="Fires after a row has been databound.";
	public const string GridView_PageCount="The current page count.";
	public const string GridView_PageIndex="The index of the current page.";
	public const string GridView_PagerSettings="Controls the paging UI settings associated with the control.";
	public const string GridView_PageSize="The number of rows from the data source to display per page.";
	//GridView_PreviousRow="Previous Row
	public const string GridView_RowHeaderColumn="The data source field corresponding to the column that is the row header.";
	public const string GridView_Rows="The collection of rows.";
	public const string GridView_ShowHeaderWhenEmpty="Whether to the show the header when displaying the EmptyDataTemplate.";
	public const string GridView_SelectedIndex="The index of the currently selected row.";
	public const string GridView_SelectedRow="The currently selected row.";
	public const string GridView_SelectedRowStyle="The style applied to selected rows.";
	public const string GridView_SortDirection="The direction in which to sort the field.";
	public const string GridView_SortExpression="Sort expression used to sort the data source to which the GridView is binding.";
	public const string GridView_SortedAscendingCellStyle="The style applied to cells when sorting in ascending order.";
	public const string GridView_SortedDescendingCellStyle="The style applied to cells when sorting in descending order.";
	public const string GridView_SortedAscendingHeaderStyle="The style applied to header when sorting in ascending order.";
	public const string GridView_SortedDescendingHeaderStyle="The style applied to header when sorting in descending order.";
	public const string GridView_VirtualItemCount="The count of visible items.";
	public const string PagerSettings_FirstPageImageUrl="The URL to the image to be used for the first page button.";
	public const string PagerSettings_FirstPageText="The text to be used on the first page button.";
	public const string PagerSettings_LastPageImageUrl="The URL to the image to be used for the last page button.";
	public const string PagerSettings_LastPageText="The text to be used on the last page button.";
	public const string PagerSettings_Mode="The type of paging UI to use.";
	public const string PagerSettings_NextPageImageUrl="The URL to the image to be used for the next page button.";
	public const string PagerSettings_PageButtonCount="Number of pages to show in the paging UI.";
	public const string PagerSettings_PreviousPageImageUrl="The URL to the image to be used for the previous page button.";
	public const string PagerStyle_Position="The position of the navigation bar.";
	public const string PagerStyle_Visible="Whether the paging UI is visible.";
	public const string Style_BackColor="Background color of the controls applied with this style.";
	public const string Style_BorderColor="Border color of the controls applied with this style.";
	public const string Style_BorderWidth="Thickness of the border around the controls applied with this style.";
	public const string Style_BorderStyle="Style of the border of controls applied with this style.";
	public const string Style_CSSClass="CSS class name applied to the user of this style.";
	public const string Style_Font="The font used for text in controls applied with this style.";
	public const string Style_ForeColor="Foreground color of the controls applied with this style.";
	public const string Style_Height="The height of the controls applied with this style.";
	public const string Style_Width="The width of the controls applied with this style.";

	public const string Substitution_MethodNameDescr="The name of the substitution callback static method.";
	public const string Substitution_CannotBeInCachedControl="Substitution controls cannot be used in cached User Controls or cached Master Pages.";
	public const string Substitution_BadMethodName="Cannot find static method '{0}' matching HttpResponseSubstitutionCallback.";
	public const string Substitution_NotAllowed="Adding a Substitution control to a control collection is not permitted.";
	public const string Substitution_SiteNotAllowed="Setting the Site on a Substitution control is not permitted.";
	public const string Table_SectionsMustBeInOrder="The table {0} must contain row sections in order of header, body, then footer.";
	public const string Table_BackImageUrl="The background image of the table.";
	public const string Table_Caption="The caption associated with the table.";
	public const string Table_CellSpacing="The spacing between the table cells.";
	public const string Table_CellPadding="The padding within the table cells.";
	public const string Table_GridLines="Which grid lines to display between the table cells.";
	public const string Table_HorizontalAlign="The horizontal alignment of the table.";
	public const string Table_Rows="The collection of rows within the table.";

	public const string TableCell_AssociatedHeaderCellNotFound="The cell {0} listed as an associated header cell was not found.";
	public const string TableCell_AssociatedHeaderCellID=" Lists the header cell IDs associated with the current table cell. This attribute is rendered with the HTML headers attribute.";
	public const string TableCell_ColumnSpan="The number of columns this cell spans.";
	public const string TableCell_RowSpan="The number of rows this cell spans.";
	public const string TableCell_Text="The text to be rendered within the cell.";
	public const string TableCell_Wrap="Whether the cell content should wrap or not.";
	public const string TableHeaderCell_AbbreviatedText="Sets the abbreviated text for a header cell. The abbreviated text is rendered with the HTML abbr attribute. The abbr attribute is important for screen readers since it allows them to read a shortened version of a header for each cell in the table.";
	public const string TableHeaderCell_Scope="Represents the cells that the header applies to. Renders the HTML SCOPE attribute. Possible values are from the TableHeaderScope enumeration: Column and Row.";
	public const string TableHeaderCell_CategoryText="Contains a list of categories associated with the table header (read by screen readers). The categories can be any string values. The categories are rendered as a comma delimited list using the HTML axis attribute.";
	public const string TableItemStyle_Wrap="Whether the cell content should wrap or not.";
	public const string TableRow_Cells="The collection of cells within the table row.";
	public const string TableRow_TableSection="The tablesection for the table row.";
	public const string TableSectionStyle_Visible="Determines whether the table section is visible.";
	public const string TableStyle_BackImageUrl="The background image within the table.";
	public const string TableStyle_CellPadding="The spacing within cells of the table.";
	public const string TableStyle_CellSpacing="The spacing between cells of the table.";
	public const string TableStyle_GridLines="The type of grid to be shown within the table.";
	public const string TableStyle_InvalidCellSpacing="CellSpacing must be greater than -1.";
	public const string TableStyle_InvalidCellPadding="CellPadding must be greater than -1.";
	public const string TableStyle_HorizontalAlign="The horizontal alignment of the table.";
	public const string Control_Missing_Attribute="The required attribute '{0}' is not found on '{1}' control.";

	public const string TemplateColumn_EditItemTemplate="The template to use for rows in edit mode in this column.";
	public const string TemplateColumn_FooterTemplate="The template to use for the footer in this column.";
	public const string TemplateColumn_HeaderTemplate="The template to use for the header in this column.";
	public const string TemplateColumn_ItemTemplate="The template to use for rows in this column.";
	public const string TemplateField_AlternatingItemTemplate="The template to use for alternating items in this field.";
	//TemplateField_ConvertEmptyStringToNull="Whether the field treats empty strings as null when the value is extracted from the field.
	public const string TemplateField_EditItemTemplate="The template to use for items in edit mode in this field.";
	public const string TemplateField_FooterTemplate="The template to use for the footer in this field.";
	public const string TemplateField_HeaderTemplate="The template to use for the header in this field.";
	public const string TemplateField_InsertItemTemplate="The template to use for items in insert mode in this field.";
	public const string TemplateField_ItemTemplate="The template to use for items in this field.";
	public const string TextBox_AutoCompleteType="The type of input content used by client browsers for auto completion.";
	public const string TextBox_AutoPostBack="Automatically postback to the server after the text is modified.";
	public const string TextBox_Columns="The width of the textbox in characters.";
	public const string TextBox_InvalidColumns="Columns must be greater than -1.";
	public const string TextBox_InvalidRows="Rows must be greater than -1.";
	public const string TextBox_MaxLength="The maximum number of characters that can be entered.";
	public const string TextBox_TextMode="The behavior mode of the textbox.";
	public const string TextBox_ReadOnly="Whether the text in the control can be changed or not.";
	public const string TextBox_Rows="The number of lines to display for a multi-line textbox.";
	public const string TextBox_Text="The text value.";
	public const string TextBox_Wrap="Whether the text should wrap or not.";
	public const string TextBox_OnTextChanged="Fires when the text property has been changed.";
	public const string TreeNodeStyle_ChildNodesPadding="Gets and sets the vertical spacing between the node and its child nodes.";
	public const string TreeNodeStyle_HorizontalPadding="The amount of horizontal padding around the node text.";
	public const string TreeNodeStyle_ImageUrl="The URL of the image rendered on nodes.";
	public const string TreeNodeStyle_NodeSpacing="The amount of vertical spacing between nodes.";
	public const string TreeNodeStyle_VerticalPadding="The amount of vertical padding around the node text.";
	public const string TreeNodeStyleCollection_InvalidArgument="TreeNodeStyleCollection can only contain TreeNodeStyles.";
	public const string TreeNodeBinding_Depth="The tree depth associated with the tree level object.";
	public const string TreeNodeBinding_EmptyBindingText="(Empty)";
	public const string TreeNodeBinding_FormatString="The format string to use when formatting the value retrieved from TextField, for example: "Node {0}".";
	public const string TreeNodeBinding_ImageToolTip="The default image tooltip for all nodes in this level when data binding.";
	public const string TreeNodeBinding_ImageToolTipField="The table column or XML attribute name to use for the node's ImageToolTip property when data binding.";
	public const string TreeNodeBinding_ImageUrl="The default image URL for all nodes in this level when data binding.";
	public const string TreeNodeBinding_ImageUrlField="The table column or XML attribute name to use for the node's ImageUrl property when data binding.";
	public const string TreeNodeBinding_NavigateUrl="The default navigation URL for all nodes in this level when data binding.";
	public const string TreeNodeBinding_NavigateUrlField="The table column or XML attribute name to use for the node's NavigateUrl property when data binding.";
	public const string TreeNodeBinding_PopulateOnDemand="If set to true, the TreeView populates data at the hierarchy-level represented by the TreeNodeBinding object on-demand (when the node is expanded), either by calling a service directly from the client (if TreeView.PopulateNodesFromClient is set) or by causing a postback to the server.  If set to false, the TreeView populates node data all-at-once, when the page containing the TreeView is first requested.";
	public const string TreeNodeBinding_SelectAction="The default select action for all nodes in this level when data binding.";
	public const string TreeNodeBinding_ShowCheckBox="The default show checkbox state for all nodes in this level when data binding.";
	public const string TreeNodeBinding_Target="The default navigation target for all nodes in this level when data binding.";
	public const string TreeNodeBinding_TargetField="The table column or XML attribute name to use for the node's Target property when data binding.";
	public const string TreeNodeBinding_Text="The default text for all nodes in this level when data binding.";
	public const string TreeNodeBinding_TextField="The table column or XML attribute name to use for a node's Text property when data binding.";
	public const string TreeNodeBinding_ToolTip="The default tooltip for all nodes in this level when data binding.";
	public const string TreeNodeBinding_ToolTipField="The table column or XML attribute name to use for the node's ToolTip property when data binding.";
	public const string TreeNodeBinding_Value="The default value for all nodes in this level when data binding.";
	public const string TreeNodeBinding_ValueField="The table column or XML attribute name to use for an item's Value property when databinding. When binding to a data source, this is usually a unique key in the current level view.";
	public const string TreeNodeCollection_InvalidArrayType="TreeNode[] expected.";
	public const string TreeNode_Checked="The checked state of the tree node.";
	public const string TreeView_DataSourceReturnedNullView="The IHierarchicalDataSource that is the data source for TreeView '{0}' returned a null view for the given view path.";
	public const string TreeNode_Expanded="The expand state of the tree node.";
	public const string TreeNode_ImageToolTip="The tooltip of the image associated with the tree node.";
	public const string TreeNode_ImageUrl="The URL for the image for the tree node.";
	public const string TreeView_InvalidDataBinding="Could not bind to the '{0}' property (specified by {1}) while data binding TreeView.  Please check the Bindings fields.";
	//TreeView_InvalidDepth="The depth of the selected item is larger than MaxDatabindDepth. This could be caused by an invalid declaration, by a change since the last request or by a forged request.
	public const string TreeNode_NavigateUrl="The URL to which the tree node navigates when selected.";
	public const string TreeNode_PopulateOnDemand="Whether the node should populate its child nodes on demand.";
	public const string TreeView_PopulateOnlyForDataSourceControls="PopulateOnDemand only supported when binding the TreeView to a data source control using the DataSourceID property or when the TreeNodePopulate event is handled.";
	public const string TreeView_PopulateOnlyEmptyNodes="PopulateOnDemand can't be set to true on a node that already has children.";
	public const string TreeNode_Selected="The select state of the tree node.";
	public const string TreeNode_SelectAction="The action that the node takes when selected.";
	public const string TreeNode_ShowCheckBox="Whether the node should show its checkbox.";
	public const string TreeNode_Target="The navigate target used when the node is selected.";
	public const string TreeNode_Text="The display text of the tree node.";
	public const string TreeNode_ToolTip="The tooltip of the tree node.";
	public const string TreeNode_Value="The value of the tree node.";
	public const string TreeView_AutoGenerateDataBindings="Whether the tree will automatically bind to data.";
	public const string TreeView_DataBindings="The data bindings for nodes in the tree.";
	public const string TreeView_CollapseImageToolTip="The tooltip format string of the image that collapses a node when clicked.";
	public const string TreeView_CollapseImageToolTipDefaultValue="Collapse {0}";
	public const string TreeView_CollapseImageUrl="The URL of the image that collapses a node when clicked.";
	public const string TreeView_Default_SkipLinkText="Skip Navigation Links.";
	public const string TreeView_EnableClientScript="Whether the TreeView should try to use client-script.";
	public const string TreeView_ExpandImageToolTip="The tooltip format string of the image that expands a node when clicked.";
	public const string TreeView_ExpandImageToolTipDefaultValue="Expand {0}";
	public const string TreeView_ExpandImageUrl="The URL to the image that expands a node when clicked.";
	public const string TreeView_HoverNodeStyle="The style that gets applied when the mouse hovers over a node (only available when client script is enabled).";
	public const string TreeView_ExpandDepth="When data binding, how many levels of the tree to expand by default.";
	public const string TreeView_ImageSet="Whether to use the packaged images or those specified in the properties of TreeView.";
	public const string TreeView_LeafNodeStyle="The style applied to leaf nodes.";
	public const string TreeView_LevelStyles="The tree styles to be applied at each level of the tree.";
	public const string TreeView_LineImagesFolderUrl="The relative folder that contains the line images for the TreeView.";
	public const string TreeView_MaxDataBindDepth="The maximum depth to which the TreeView will databind.";
	public const string TreeView_NoExpandImageUrl="The URL of the image that represents the absence of an expand/collapse icon.";
	public const string TreeView_NodeIndent="The number of pixels to indent each node.";
	public const string TreeView_Nodes="The initial collection of nodes for the tree.";
	public const string TreeView_NodeStyle="The default style applied to all nodes.";
	public const string TreeView_NodeWrap="Whether the node text should be word wrapped.";
	public const string TreeView_ParentNodeStyle="The style applied to parent nodes (excluding root nodes).";
	public const string TreeView_PathSeparator="The character used to separate parts of the path.";
	public const string TreeView_PopulateNodesFromClient="Whether the TreeView should try to populate nodes from the client (without posting back).";
	public const string TreeView_RootNodeStyle="The style applied to root nodes.";
	public const string TreeView_SelectedNodeStyle="The style applied to the selected node.";
	public const string TreeView_ShowCheckBoxes="The node types next to which checkboxes should be shown.";
	public const string TreeView_ShowExpandCollapse="Whether to show the expand/collapse icon next to the nodes.";
	public const string TreeView_ShowLines="Whether to show lines connecting the tree nodes.";
	public const string TreeView_SkipLinkText="The text that appears in the ALT attribute of the invisible image link that allows screen readers to skip repetitive content.";
	public const string TreeView_CheckChanged="Fired after the check state of a node changes.";
	public const string TreeView_SelectedNodeChanged="Fired after the selected node changes.";
	public const string TreeView_TreeNodeCollapsed="Fired after a TreeNode is collapsed.";
	public const string TreeView_TreeNodeExpanded="Fired after a TreeNode is expanded.";
	public const string TreeView_TreeNodeDataBound="Fired after a TreeNode is databound.";
	public const string TreeView_TreeNodePopulate="Fired when a TreeNode is being populated.";
	public const string ValidationSummary_DisplayMode="Format for error summary display.";
	public const string ValidationSummary_HeaderText="Header text to display in the summary.";
	public const string ValidationSummary_ShowMessageBox="Whether to display a message box on error in up-level browsers.";
	public const string ValidationSummary_ShowModelStateErrors="Whether the model state errors from a data operation should be shown.";
	public const string ValidationSummary_ShowSummary="Whether to display the summary text on the page.";
	public const string ValidationSummary_ShowValidationErrors="Whether the validation summary from validators should be shown.";
	public const string ValidationSummary_EnableClientScript="Whether to update the summary on the client in up-level browsers.";
	public const string ValidationSummary_ValidationGroup="The group to which the validation summary belongs.";
	public const string PostBackControl_ValidationGroup="The group that should be validated when the control causes a postback.";
	public const string AutoPostBackControl_CausesValidation="Whether the control causes validation to fire.";

	public const string Calendar_Caption="The caption associated with the calendar.";
	public const string Calendar_CellPadding="The padding within cells.";
	public const string Calendar_CellSpacing="The spacing between cells.";
	public const string Calendar_DayHeaderStyle="The style applied to the day header row.";
	public const string Calendar_DayNameFormat="Format for day header text.";
	public const string Calendar_DayStyle="The style applied to days.";
	public const string Calendar_FirstDayOfWeek="Which day of the week is displayed first.";
	public const string Calendar_NextMonthText="Text for the next month button.";
	public const string Calendar_NextPrevFormat="Format for month navigation buttons.";
	public const string Calendar_NextPrevStyle="The style applied to month navigation buttons.";
	public const string Calendar_OtherMonthDayStyle="The style applied to days from adjacent months";
	public const string Calendar_PrevMonthText="Text for the previous month button";
	public const string Calendar_SelectedDate="The currently selected date.";
	public const string Calendar_SelectedDates="The set of selected dates for use when range selection is enabled.";
	public const string Calendar_SelectedDayStyle="The style of currently selected days.";
	public const string Calendar_SelectionMode="Determines whether days, weeks and months are selectable.";
	public const string Calendar_SelectMonthText="Text for the select month button.";
	public const string Calendar_SelectorStyle="The style applied to the week and month selector column.";
	public const string Calendar_SelectWeekText="Text for select week button.";
	public const string Calendar_ShowDayHeader="True if showing days of week header.";
	public const string Calendar_ShowGridLines="True if showing grid lines.";
	public const string Calendar_ShowNextPrevMonth="True if showing the next/previous month buttons.";
	public const string Calendar_ShowTitle="True if showing the title.";
	public const string Calendar_TitleFormat="Format for month title in header.";
	public const string Calendar_TitleStyle="The style applied to the title.";
	public const string Calendar_TodayDayStyle="The style applied to today's date.";
	public const string Calendar_TodaysDate="The current date as displayed by the Calendar.";
	public const string Calendar_VisibleDate="The month to be displayed.";
	public const string Calendar_WeekendDayStyle="The style applied to weekend days.";
	public const string Calendar_OnDayRender="Fires as a day is being rendered.";
	public const string Calendar_OnSelectionChanged="Fires when selection is changed by the user.";
	public const string Calendar_OnVisibleMonthChanged="Fires when visible month is changed by the user.";
	public const string Calendar_TitleText="Calendar";
	public const string Calendar_PreviousMonthTitle="Go to the previous month";
	public const string Calendar_NextMonthTitle="Go to the next month";
	public const string Calendar_SelectMonthTitle="Select the whole month";
	public const string Calendar_SelectWeekTitle="Select week {0}";

	public const string View_Activate="Fires when the view control is activated.";
	public const string View_Deactivate="Fires when the view control is deactivated.";
	public const string ViewCollection_must_contain_view="Controls added to a ViewCollection must be of type View.";
	public const string WebControl_AccessKey="Keyboard shortcut used by the control.";
	public const string WebControl_InvalidAccessKey="AccessKey too long, cannot be more than one character.";
	public const string WebControl_Attributes="Tag attributes of the control.";
	public const string WebControl_BackColor="Color of the background of the control.";
	public const string WebControl_BorderColor="Color of the border around the control.";
	public const string WebControl_BorderWidth="Width of the border around the control.";
	public const string WebControl_BorderStyle="Style of the border around the control.";
	public const string WebControl_CSSClassName="CSS Class name applied to the control.";
	public const string WebControl_ControlStyle="The style associated with the control.";
	public const string WebControl_ControlStyleCreated="Whether the style associated with the control has been created.";
	public const string WebControl_Enabled="Enabled state of the control.";
	public const string WebControl_Font="The font used for text within the control.";
	public const string WebControl_ForeColor="Color of the text within the control.";
	public const string WebControl_Height="The height of the control.";
	public const string WebControl_Style="Low-level access to control styles.";
	public const string WebControl_TabIndex="The tab order of the control.";
	public const string WebControl_Tooltip="The tooltip displayed when the mouse is over the control.";
	public const string WebControl_Width="The width of the control.";
	//WebServiceDataSourceControl_CacheEnabled="Whether to internally cache the Web Service data.
	//WebServiceDataSourceControl_CacheKey="Key used as part of the cache id.
	//WebServiceDataSourceControl_CacheTime="Length of time to keep the cache.
	//WebServiceDataSourceControl_Method="Describes the Web Service method to be called.
	//WebServiceDataSourceControl_Timeout="Milliseconds to wait for a Web Service response.
	//WebServiceDataSourceControl_TypeName="The Web Service proxy type identifier.
	//WebServiceDataSourceControl_URL="An alternate URL for the Web Service.
	//WebServiceDataSourceControl_OnWebServiceExceptionCaught="Fires when an exception is thrown in calling the Web Service.
	//WebServiceMethod_Parameters="A list of parameters to be passed to the Web Service method.
	//WebServiceMethod_Name="The name of the Web Service method.
	//Wizard_only_one_wizardStep_allowed="Only one <wizardSteps> is allowed inside the {0} control.
	public const string Wizard_ActiveStep="The active WizardStep control.";
	public const string Wizard_ActiveStepIndex="The index of the active WizardStep control.";
	public const string Wizard_ActiveStepIndex_out_of_range="The ActiveStepIndex must be less than WizardSteps.Count and at least -1.  For dynamically added steps, make sure they are added before or in Page_PreInit event.";
	public const string Wizard_CancelButtonClick="Fires when the cancel button is clicked.";
	public const string Wizard_CancelButtonImageUrl="The URL for the image to be used for the cancel button.";
	public const string Wizard_CancelButtonText="The text of the cancel button.";
	public const string Wizard_CancelButtonType="The button type of the cancel button.";
	public const string Wizard_CancelButtonStyle="The style of the cancel button.";
	public const string Wizard_CancelDestinationPageUrl="The URL to redirect to when the cancel button is clicked.";
	public const string Wizard_CellPadding="The padding within cells.";
	public const string Wizard_CellSpacing="The spacing between cells.";
	public const string Wizard_Default_CancelButtonText="Cancel";
	public const string Wizard_DisplayCancelButton="Indicates whether cancel button is displayed.";
	public const string Wizard_FinishDestinationPageUrl="The URL to redirect to when the finish button is clicked.";
	public const string Wizard_FinishCompleteButtonStyle="The style of the finish step button.";
	public const string Wizard_FinishCompleteButtonText="The text of the finish step button.";
	public const string Wizard_FinishCompleteButtonType="The button type of the finish step button.";
	public const string Wizard_FinishCompleteButtonImageUrl="The URL for the image to be used for the finish button.";
	public const string Wizard_FinishPreviousButtonStyle="The style of the finish step's previous button.";
	public const string Wizard_FinishPreviousButtonText="The text of the finish step's previous button.";
	public const string Wizard_FinishPreviousButtonType="The button type of the finish step's previous button.";
	public const string Wizard_FinishPreviousButtonImageUrl="The URL for the image to be used for the finish step's previous button";
	public const string Wizard_FinishNavigationTemplate="The template used for finish navigation layout.";
	public const string Wizard_InvalidBubbleEvent="The command '{0}' is not valid for the previous step, make sure the step type is not changed between postbacks.";
	public const string Wizard_NavigationButtonStyle="The style of the navigation buttons.";
	public const string Wizard_NavigationStyle="The style applied to the navigation layout.";
	public const string Wizard_StepNextButtonStyle="The style of the next step button.";
	public const string Wizard_StepNextButtonText="The text of the next step button.";
	public const string Wizard_StepNextButtonType="The button type of the next step button.";
	public const string Wizard_StepNextButtonImageUrl="The URL for the image to be used for the next button.";
	public const string Wizard_StepPreviousButtonStyle="The style of the previous step button.";
	public const string Wizard_StepPreviousButtonText="The text of the previous step button.";
	public const string Wizard_StepPreviousButtonType="The button type of the previous step button.";
	public const string Wizard_StepPreviousButtonImageUrl="The URL for the image to be used for the previous button.";
	public const string Wizard_SideBarButtonStyle="The style of the side bar buttons.";
	public const string Wizard_DisplaySideBar="Indicates whether sidebar is displayed.";
	public const string Wizard_SideBarStyle="The style applied to the side bar.";
	public const string Wizard_SideBarTemplate="The template used for the side bar layout.";
	public const string Wizard_StartNavigationTemplate="The template used for the start navigation layout.";
	public const string Wizard_StartNextButtonStyle="The style of the start step's next button.";
	public const string Wizard_StartNextButtonText="The text of the start step's next button.";
	public const string Wizard_StartNextButtonType="The type of the start step's next button.";
	public const string Wizard_StartNextButtonImageUrl="The URL for the image to be used for the start step's next button.";
	public const string Wizard_Step_Not_In_Wizard="The step cannot be found in Wizard's WizardSteps collection.";
	public const string Wizard_StepNavigationTemplate="The template used for the step navigation layout.";
	public const string Wizard_StepStyle="The style applied to the steps.";
	public const string Wizard_WizardSteps="The collection of the WizardStep controls inside the control.";
	public const string Wizard_HeaderText="The header text of wizard control.";
	public const string Wizard_Default_SkipToContentText="Skip Navigation Links.";
	public const string Wizard_ActiveStepChanged="Fires when the active step is changed.";
	public const string Wizard_FinishButtonClick="Fires when the finish button is clicked.";
	public const string Wizard_NextButtonClick="Fires when the next button is clicked.";
	public const string Wizard_PreviousButtonClick="Fires when the previous button is clicked.";
	public const string Wizard_SideBarButtonClick="Fires when the sidebar button is clicked.";
	public const string Wizard_Default_StepPreviousButtonText="Previous";
	public const string Wizard_Default_StepNextButtonText="Next";
	public const string Wizard_Default_FinishButtonText="Finish";
	public const string Wizard_SideBar_Button_Not_Found="{0} control must contain an IButtonControl with ID {1} in every item template, this maybe include ItemTemplate, EditItemTemplate, SelectedItemTemplate or AlternatingItemTemplate if they exist.";
	public const string Wizard_DataList_Not_Found="SideBarTemplate must contain a ListView control or a DataList control with ID {0} to enable the side bar navigation feature.";
	public const string Wizard_Cannot_Modify_ControlCollection="The Control collection cannot be modified.";
	public const string Wizard_Header_Placeholder_Must_Be_Specified_For_HeaderTemplate="A header placeholder must be specified on Wizard '{0}' when HeaderTemplate is set. Specify a placeholder by setting a control's ID property to "{1}". The placeholder control must also specify runat=""server".";
	public const string Wizard_Header_Placeholder_Must_Be_Specified_For_HeaderText="A header placeholder must be specified on Wizard '{0}' when HeaderText is set. Specify a placeholder by setting a control's ID property to "{1}". The placeholder control must also specify runat=""server".";
	public const string Wizard_Navigation_Placeholder_Must_Be_Specified="A navigation placeholder must be specified on Wizard '{0}'. Specify a placeholder by setting a control's ID property to "{1}". The placeholder control must also specify runat=""server".";
	public const string Wizard_Sidebar_Placeholder_Must_Be_Specified="A sidebar placeholder must be specified on Wizard '{0}' when DisplaySideBar is set to true. Specify a placeholder by setting a control's ID property to "{1}". The placeholder control must also specify runat=""server".";
	public const string Wizard_Step_Placeholder_Must_Be_Specified="A step placeholder must be specified on Wizard '{0}'. Specify a placeholder by setting a control's ID property to "{1}". The placeholder control must also specify runat=""server".";
	public const string Wizard_LayoutTemplate="The template used for a customized layout.";


	public const string Wizard_WizardStepOnly="Only WizardStep can be added to WizardControlCollection.";
	public const string WizardStep_AllowReturn="Determines whether the step can be visited more than once.";
	public const string WizardStep_Name="The name of wizard step.";
	public const string WizardStep_Title="The title of wizard step.";
	public const string WizardStep_StepType="The type of wizard step.";
	public const string WizardStep_WrongContainment="WizardStep can only be placed inside the <WizardSteps> tag of a Wizard control.";
	public const string Xml_DocumentContent="The XML string that the transform is applied to.";
	public const string Xml_DocumentSource="The XML file that the transform is applied to.";
	public const string Xml_TransformSource="The XSL file used to transform the XML data.";
	public const string Xml_Document="The XML document that the transform is applied to.";
	public const string Xml_Transform="The XSL transform used on the XML data.";
	public const string Xml_TransformArgumentList="The argument list used by the XSL stylesheet.";
	public const string Xml_XPathNavigator="The XPathNavigator that the transform is applied to.";
	public const string XmlDataSource_Data="Inline XML data. This is only used if no file is specified in the DataFile property.";
	public const string XmlDataSource_DataFile="The path to an XML data file.";
	public const string XmlDataSource_Transform="Inline XML transform. This is only used if no file is specified in the TransformFile property.";
	public const string XmlDataSource_TransformFile="The path to an XML transform file.";
	public const string XmlDataSource_XPath="Specifies an initial XPath that is applied to the XML data.";
	public const string XmlDataSource_Transforming="This event is raised before the transform is applied.";

#endif

#if false

	// WebParts

	public const string AppearanceEditorPart_Title="Title";
	public const string AppearanceEditorPart_Height="Height";
	public const string AppearanceEditorPart_Width="Width";
	public const string AppearanceEditorPart_ChromeType="Chrome Type";
	public const string AppearanceEditorPart_Hidden="Hidden";
	public const string AppearanceEditorPart_Direction="Direction";
	public const string AppearanceEditorPart_PartTitle="Appearance";
	public const string AppearanceEditorPart_Pixels="pixels";
	public const string AppearanceEditorPart_Points="points";
	public const string AppearanceEditorPart_Picas="picas";
	public const string AppearanceEditorPart_Inches="inches";
	public const string AppearanceEditorPart_Millimeters="millimeters";
	public const string AppearanceEditorPart_Centimeters="centimeters";
	public const string AppearanceEditorPart_Percent="percent";
	public const string AppearanceEditorPart_Em="em";
	public const string AppearanceEditorPart_Ex="ex";
	public const string BehaviorEditorPart_AllowClose="Allow Close";
	public const string BehaviorEditorPart_AllowConnect="Allow Connect";
	public const string BehaviorEditorPart_AllowHide="Allow Hide";
	public const string BehaviorEditorPart_AllowMinimize="Allow Minimize";
	public const string BehaviorEditorPart_AllowZoneChange="Allow Zone Change";
	public const string BehaviorEditorPart_ExportMode="Export Mode";
	public const string BehaviorEditorPart_ExportModeNone="Do not allow";
	public const string BehaviorEditorPart_ExportModeAll="Export all data";
	public const string BehaviorEditorPart_ExportModeNonSensitiveData="Non-sensitive data only";
	public const string BehaviorEditorPart_HelpMode="Help Mode";
	public const string BehaviorEditorPart_HelpModeModal="Modal";
	public const string BehaviorEditorPart_HelpModeModeless="Modeless";
	public const string BehaviorEditorPart_HelpModeNavigate="Navigate";
	public const string BehaviorEditorPart_Description="Description";
	public const string BehaviorEditorPart_TitleLink="Title Link";
	public const string BehaviorEditorPart_TitleIconImageLink="Title Icon Image Link";
	public const string BehaviorEditorPart_CatalogIconImageLink="Catalog Icon Image Link";
	public const string BehaviorEditorPart_HelpLink="Help Link";
	public const string BehaviorEditorPart_ImportErrorMessage="Import Error Message";
	public const string BehaviorEditorPart_AuthorizationFilter="Authorization Filter";
	public const string BehaviorEditorPart_AllowEdit="Allow Edit";
	public const string BehaviorEditorPart_PartTitle="Behavior";
	public const string BlobPersonalizationState_CantApply="Cannot apply personalization data to '{0}', because personalization data was already applied to a control with this ID.";
	public const string BlobPersonalizationState_CantExtract="Cannot extract personalization data for '{0}', because personalization data was never applied to this control.  Ensure that the control's ID has not changed since personalization data was applied.";
	public const string BlobPersonalizationState_DeserializeError="Cannot deserialize the blob of personalization data associated with the current page.";
	public const string BlobPersonalizationState_NotApplied="Personalization data has not been applied.";
	public const string BlobPersonalizationState_NotLoaded="Personalization data has not been loaded.";
	//CatalogDisplayMode_Description="Allows the user to add Web Parts from a catalog to the page.
	//CatalogDisplayMode_Name="Catalog Mode
	public const string CatalogPart_MustBeInZone="CatalogPart '{0}' must be placed in a CatalogZone.";
	public const string CatalogPart_SampleWebPartTitle="WebPart {0}";
	public const string CatalogPart_UnknownDescription="Unknown description.";
	//CatalogPart_ZoneMustBeRegistered="Zone must be registered with the WebPartManager.
	public const string CatalogZone_OnlyCatalogParts="Should only have catalog parts in the ZoneTemplate of '{0}'.";
	public const string CatalogZoneBase_AddVerb="Verb to add a Web Part to a Zone.";
	//CatalogZoneBase_AvailableCatalogText="The text shown above the list of available CatalogParts.
	public const string CatalogZoneBase_CloseVerb="Verb to close the CatalogZone.";
	public const string CatalogZoneBase_DefaultEmptyZoneText="Catalog Zone contains no Catalog Parts.";
	public const string CatalogZoneBase_DefaultSelectTargetZoneText="Add to:";
	public const string CatalogZoneBase_HeaderText="Catalog Zone";
	public const string CatalogZoneBase_InstructionText="Select the catalog you would like to browse.";
	public const string CatalogZoneBase_NoCatalogPartID="CatalogPart does not have an ID.";
	public const string CatalogZoneBase_PartLinkStyle="The style applied to each link to select a CatalogPart.";
	public const string CatalogZoneBase_SelectCatalogPart="Selects '{0}'";
	public const string CatalogZoneBase_SelectedCatalogPartID="ID of the selected CatalogPart.";
	public const string CatalogZoneBase_SelectedPartLinkStyle="The style applied to the link to the currently selected CatalogPart.";
	public const string CatalogZoneBase_SelectTargetZoneText="The text shown next to the dropdown for selecting the target Zone.";
	public const string CatalogZoneBase_ShowCatalogIcons="Whether an icon should be displayed next to each item in a CatalogPart.";
	//ConnectDisplayMode_Description="Allows the user to connect and disconnect Web Parts.
	//ConnectDisplayMode_Name="Connect Mode
	public const string ConnectionConsumerAttribute_InvalidConnectionPointType="Type '{0}' is not a valid consumer connection point.  It must be public, a subclass of ConsumerConnectionPoint, and have a public constructor with the same parameters as the ConsumerConnectionPoint constructor.";
	public const string ConnectionProviderAttribute_InvalidConnectionPointType="Type '{0}' is not a valid provider connection point.  It must be public, a subclass of ProviderConnectionPoint, and have a public constructor with the same parameters as the ProviderConnectionPoint constructor.";
	public const string ConnectionsZone_CancelVerb="Verb to cancel the current action.";
	public const string ConnectionsZone_ConfigureConnectionTitle="Configure Connection";
	public const string ConnectionsZone_ConfigureConnectionTitleDescription="The title for the connection configuration mode.";
	public const string ConnectionsZone_ConfigureVerb="Verb to configure a connection.";
	public const string ConnectionsZone_ConnectToConsumerInstructionText="Create consumer connections for this Web Part.";
	public const string ConnectionsZone_ConnectToConsumerInstructionTextDescription="The instruction text when creating a connection to a consumer.";
	public const string ConnectionsZone_ConnectToConsumerText="Create a connection to a Consumer";
	public const string ConnectionsZone_ConnectToConsumerTextDescription="The text of the link to the creation of a new connection to a consumer.";
	public const string ConnectionsZone_ConnectToConsumerTitle="Send Data to Web Part";
	public const string ConnectionsZone_ConnectToConsumerTitleDescription="The title when creating a new connection to a consumer.";
	public const string ConnectionsZone_ConnectToProviderInstructionText="Create provider connections for this Web Part.";
	public const string ConnectionsZone_ConnectToProviderInstructionTextDescription="The instruction text when creating a new connection to a consumer.";
	public const string ConnectionsZone_ConnectToProviderText="Create a connection to a Provider";
	public const string ConnectionsZone_ConnectToProviderTextDescription="The text of the link to the creation of a new connection to a provider.";
	public const string ConnectionsZone_ConnectToProviderTitle="Get Data from Web Part";
	public const string ConnectionsZone_ConnectToProviderTitleDescription="The title when creating a new connection to a provider.";
	public const string ConnectionsZone_ConnectVerb="Verb to connect two Web Parts.";
	public const string ConnectionsZone_ConsumersInstructionText="Web parts that the current Web part sends information to:";
	public const string ConnectionsZone_ConsumersInstructionTextDescription="The text that describes the list of existing connections to consumers.";
	public const string ConnectionsZone_ConsumersTitle="Consumers";
	public const string ConnectionsZone_ConsumersTitleDescription="The legend for the set of existing connections to consumers.";
	public const string ConnectionsZone_CloseVerb="Verb to close the ConnectionsZone.";
	public const string ConnectionsZone_DisconnectVerb="Verb to disconnect two Web Parts.";
	public const string ConnectionsZone_DisconnectInvalid="The provider or the consumer of the connection to disconnect must be the currently selected Web Part.";
	public const string ConnectionsZone_ErrorCantContinueConnectionCreation="Can't continue with the creation of this connection because at least one of the Web Parts or connection points has disappeared or has become incompatible with the currently selected Web Part or is already used by another connection and doesn't support multiple connections.";
	public const string ConnectionsZone_ErrorMessage="The message that's displayed by the connections zone when it can't create or continue creating a connection.";
	public const string ConnectionsZone_Get="Get:";
	public const string ConnectionsZone_GetDescription="The text that appears before consumer connection point names.";
	public const string ConnectionsZone_GetFromText="From:";
	public const string ConnectionsZone_GetFromTextDescription="The text that appears before provider names.";
	public const string ConnectionsZone_HeaderText="Connections Zone";
	public const string ConnectionsZone_HeaderTextDescription="The text that appears in the header of the connections zone.";
	public const string ConnectionsZone_InstructionText="Manage the connections for the current Web part.";
	public const string ConnectionsZone_InstructionTextDescription="The instruction text when the connections zone is displaying existing connections.";
	public const string ConnectionsZone_InstructionTitle="Manage the connections for {0}";
	public const string ConnectionsZone_InstructionTitleDescription="The title when the connections zone is displaying existing connections. The name of the Web part to connect is appended to this text at run-time.";
	public const string ConnectionsZone_MustImplementITransformerConfigurationControl="The control returned from WebPartTransformer.CreateConfigurationControl() must implement ITransformerConfigurationControl.";
	public const string ConnectionsZone_NoConsumers="No compatible consumers";
	public const string ConnectionsZone_NoExistingConnectionTitle="No active connections";
	public const string ConnectionsZone_NoExistingConnectionTitleDescription="The title when no connection exists on the selected Web part.";
	public const string ConnectionsZone_NoExistingConnectionInstructionText="There are no active connections available in your Web Part. You may create a new connection by selecting the links above if there are compatible Web Parts on the page.";
	public const string ConnectionsZone_NoExistingConnectionInstructionTextDescription="The instruction text when no connection exist on the selected Web part.";
	public const string ConnectionsZone_NoProviders="No compatible providers";
	public const string ConnectionsZone_ProvidersInstructionText="Web parts that the current Web part gets information from:";
	public const string ConnectionsZone_ProvidersInstructionTextDescription="The text that describes the list of existing connections to providers.";
	public const string ConnectionsZone_ProvidersTitle="Providers";
	public const string ConnectionsZone_ProvidersTitleDescription="The legend for the set of existing connections to providers.";
	public const string ConnectionsZone_SendText="Send:";
	public const string ConnectionsZone_SendTextDescription="The text that appears before provider connection point names.";
	public const string ConnectionsZone_SendToText="To:";
	public const string ConnectionsZone_SendToTextDescription="The text that appears before consumer names.";
	public const string ConnectionsZone_WarningConnectionDisabled="This connection is currently inactive due to the unavailability of one of its end points.";
	public const string ConnectionsZone_WarningMessage="The message that is displayed when an existing connection is no longer valid.";
	public const string ConnectionPoint_InvalidControlType="Type must be a subclass of Control.";
	public const string ContentDirection_NotSet="Not Set";
	public const string ContentDirection_LeftToRight="Left to Right";
	public const string ContentDirection_RightToLeft="Right to Left";
	public const string DeclarativeCatalogPart_PartTitle="Declarative Catalog";
	public const string DeclarativeCatlaogPart_WebPartsListUserControlPath="Path to a UserControl containing additional WebParts to display in the CatalogPart.";
	//DesignDisplayMode_Description="Allows the user to rearrange the Web Parts on the page.
	//DesignDisplayMode_Name="Design Mode
	//EditDisplayMode_Description="Allows the user to edit the properties of Web Parts.
	//EditDisplayMode_Name="Edit Mode
	public const string EditorPart_MustBeInZone="EditorPart '{0}' must be placed in an EditorZone.";
	public const string EditorPart_ErrorBadUrl="Url properties must be relative or use the http: or https: protocol.";
	public const string EditorPart_ErrorConvertingProperty="Error converting property to the required type.";
	public const string EditorPart_ErrorConvertingPropertyWithType="Property value must be of type {0}.";
	public const string EditorPart_ErrorSettingProperty="Error setting property value.";
	public const string EditorPart_ErrorSettingPropertyWithExceptionMessage="Error setting property value: {0}";
	public const string EditorPart_PropertyMaxValue="Property value must be less than or equal to {0}.";
	public const string EditorPart_PropertyMinValue="Property value must be greater than or equal to {0}.";
	public const string EditorPart_PropertyMustBeDecimal="Property value must be a decimal number.";
	public const string EditorPart_PropertyMustBeInteger="Property value must be an integer.";
	//EditorPartCollection_WrongType="Value must be of type EditorPart.
	public const string EditorZone_OnlyEditorParts="Should only have editor parts in the ZoneTemplate of '{0}'.";
	public const string EditorZoneBase_ApplyVerb="Verb to apply the changes and leave the EditorZone open.";
	public const string EditorZoneBase_CancelVerb="Verb to cancel the changes and close the EditorZone.";
	public const string EditorZoneBase_DefaultEmptyZoneText="Editor Zone contains no Editor Parts.";
	public const string EditorZoneBase_DefaultErrorText="There was an error applying one or more Editor Parts.";
	public const string EditorZoneBase_DefaultHeaderText="Editor Zone";
	public const string EditorZoneBase_DefaultInstructionText="Modify the properties of the Web Part, then click OK or Apply to apply your changes.";
	public const string EditorZoneBase_ErrorText="The text shown when there is an error in an Editor Part.";
	public const string EditorZoneBase_NoEditorPartID="EditorPart does not have an ID.";
	public const string EditorZoneBase_OKVerb="Verb to apply the changes and close the EditorZone.";
	public const string ErrorWebPart_ErrorText="Web Part Error: {0}";
	public const string GenericWebPart_CannotWrapWebPart="Web Parts cannot be wrapped by a GenericWebPart.";
	public const string GenericWebPart_CannotWrapOutputCachedControl="OutputCached controls cannot be wrapped by a GenericWebPart.";
	public const string GenericWebPart_NoID="The specified control of type '{0}' does not have an ID.";
	public const string GenericWebPart_CannotModify="Cannot modify the controls collection of a GenericWebPart.  To create a new GenericWebPart, use the WebPartManager.CreateWebPart() method.";
	public const string GenericWebPart_ChildControlIsNull="The child control inside the GenericWebPart is null.";
	//GenericWebPart_CantLoadType="Cannot load the Type of the control with ID {0}.
	public const string ImportCatalogPart_PartTitle="Imported Web Part Catalog";
	public const string ImportCatalogPart_Browse="Type a file name (.WebPart) or click "Browse" to locate a Web Part.";
	public const string ImportCatalogPart_BrowseHelpText="The help text that appears before the upload field.";
	public const string ImportCatalogPart_Upload="Once you have selected a Web Part file to import, click the Upload button.";
	public const string ImportCatalogPart_UploadHelpText="The text that appears above the upload button.";
	public const string ImportCatalogPart_UploadButton="Upload";
	public const string ImportCatalogPart_UploadButtonText="The text of the button that launches the Web Part upload.";
	public const string ImportCatalogPart_ImportedPartLabel="Imported Web Part";
	public const string ImportCatalogPart_ImportedPartErrorLabel="Error while importing Web Part";
	public const string ImportCatalogPart_PartImportErrorLabelText="The text that appears in the catalog if an error occurs during import.";
	public const string ImportCatalogPart_ImportedPartLabelText="The text that appears in the catalog above an imported part description.";
	public const string ImportCatalogPart_NoFileName="You must type a Web Part file name (.WebPart).";
	public const string LayoutEditorPart_ChromeState="Chrome State";
	public const string LayoutEditorPart_Zone="Zone";
	public const string LayoutEditorPart_ZoneIndex="Zone Index";
	public const string LayoutEditorPart_PartTitle="Layout";
	//NormalDisplayMode_Description="Allows the user to browse the Web Parts on the page.
	//NormalDisplayMode_Name="Normal Mode
	public const string PageCatalogPart_PartTitle="Page Catalog";
	public const string Part_Description="The text description of the Part.";
	public const string Part_ChromeState="Whether the Part is shown minimized or normal size.";
	public const string Part_ChromeType="The type of chrome that will be rendered around the Part.";
	public const string Part_Title="The title of the Part.";
	//Part_TitleStyle="The style applied to the title bar.
	public const string Part_Unknown="Unknown";
	public const string Part_Untitled="Untitled";
	public const string PartChromeState_Normal="Normal";
	public const string PartChromeState_Minimized="Minimized";
	public const string PartChromeType_Default="Default";
	public const string PartChromeType_TitleAndBorder="Title and Border";
	public const string PartChromeType_TitleOnly="Title Only";
	public const string PartChromeType_BorderOnly="Border Only";
	public const string PartChromeType_None="None";
	//PersonalizableAttribute_PropertyMustBePersonalizable="The property must be Personalizable.
	public const string PersonalizableTypeEntry_InvalidProperty="The '{0}' property of '{1}' is not a valid Personalizable property.  It must have a public get and set accessor, and take no index parameters.";
	public const string PersonalizationDictionary_MustBeTypeString="Value must be of type String.";
	public const string PersonalizationDictionary_MustBeTypePersonalizationEntry="Value must be of type PersonalizationEntry.";
	public const string PersonalizationDictionary_MustBeTypeDictionaryEntryArray="Value must be of type DictionaryEntry[].";
	public const string PersonalizationProvider_ApplicationNameExceedMaxLength="The ApplicationName cannot exceed character length {0}.";
	public const string PersonalizationProvider_BadConnection="The specified connectionStringName, '{0}', was not registered.";
	public const string PersonalizationProvider_CantAccess="A connection could not be made by the {0} personalization provider using the specified registration.";
	public const string PersonalizationProvider_NoConnection="The connectionStringName attribute must be specified when registering a personalization provider.";
	public const string PersonalizationProvider_UnknownProp="Invalid attribute '{0}', specified in the '{1}' personalization provider registration.";
	public const string PersonalizationProvider_WrongType="Argument must be of type BlobPersonalizationState.";
	//PropertyGridEditorPart_ErrorConvertingString="Property requires a value of type {0}.
	//PropertyGridEditorPart_ErrorText="Text shown when there is an error setting a property value entered in the property grid.
	public const string PropertyGridEditorPart_PartTitle="Property Grid";
	public const string PropertyGridEditorPart_DesignModeWebPart_BoolProperty="Sample boolean property";
	public const string PropertyGridEditorPart_DesignModeWebPart_EnumProperty="Sample enum property";
	public const string PropertyGridEditorPart_DesignModeWebPart_StringProperty="Sample string property";
	public const string ProxyWebPartConnectionCollection_ReadOnly="The StaticConnections collection of ProxyWebPartManager is read-only after connections have been activated.";
	public const string RowToFieldTransformer_FieldName="Field Name:";
	public const string RowToFieldTransformer_NoProviderSchema="No Provider Schema";
	//RowToFilterTransformer_ConsumerFieldName="Consumer Field Name:
	//RowToFilterTransformer_NoConsumerSchema="No Consumer Schema
	//RowToFilterTransformer_ProviderFieldName="Provider Field Name:
	//RowToFilterTransformer_NoProviderSchema="No Provider Schema
	public const string RowToParametersTransformer_DifferentFieldNamesLength="The number of ConsumerFieldNames and ProviderFieldNames must be the same.";
	public const string RowToParametersTransformer_ConsumerFieldName="Consumer Field Name:";
	public const string RowToParametersTransformer_NoConsumerSchema="No Consumer Schema";
	public const string RowToParametersTransformer_ProviderFieldName="Provider Field Name:";
	public const string RowToParametersTransformer_NoProviderSchema="No Provider Schema";
	public const string SqlPersonalizationProvider_Description="Personalization provider that stores data in a SQL Server database.";
	public const string ToolZone_CantSetVisible="Cannot set the Visible property of a Tool Zone.  Override the ToolZone.Display property instead.";
	public const string ToolZone_EditUIStyle="The style applied to the UI elements used for editing.";
	public const string ToolZone_HeaderCloseVerb="Verb displayed in the header to close the Zone.";
	public const string ToolZone_HeaderVerbStyle="The style applied to the HeaderCloseVerb.";
	public const string ToolZone_InstructionText="The instructional text shown in the Zone.";
	public const string ToolZone_InstructionTextStyle="The style applied to the instructional text shown in the Zone.";
	public const string ToolZone_LabelStyle="The style applied to the labels for the UI elements used for editing.";
	public const string ToolZone_DisplayModesReadOnly="The collection of DisplayModes on a ToolZone is read-only.";
	public const string WebPartTransformerAttribute_Missing="The WebPartTransformerAttribute is not defined on the type '{0}'.";
	public const string WebPartTransformerAttribute_NotTransformer="The type '{0}' is not a subclass of WebPartTransformer.";
	public const string WebPartTransformerAttribute_SameTypes="The consumer and provider types of a transformer may not be the same type.";
	public const string WebPartTransformerCollection_NotEmpty="The WebPartTransformerCollection may contain at most one WebPartTransformer.";
	public const string WebPartTransformerCollection_ReadOnly="The WebPartTransformerCollection of Connection is read-only after it has been activated.";
	public const string UnknownWebPart="The specified Web Part does not belong the collection of Web Parts on this page.";
	public const string WebPart_AllowClose="Whether the Web Part can be closed.";
	public const string WebPart_AllowConnect="Whether the Web Part can be connected to other Web Parts.";
	public const string WebPart_AllowEdit="Whether the Web Part's properties can be changed using the EditorZone.";
	public const string WebPart_AllowHide="Whether the Web Part can be hidden.";
	//WebPart_AllowLink="Whether the Web Part can be linked to external from the page.
	public const string WebPart_AllowMinimize="Whether the Web Part can be minimized.";
	public const string WebPart_AllowZoneChange="Whether the Web Part can be moved to another Zone.";
	public const string WebPart_AuthorizationFilter="String used by the WebPartManager to determine if the user is authorized to view this WebPart.";
	public const string WebPart_BadUrl="'{0}' is not a valid Url.  It must be relative or use the http: or https: protocol.";
	public const string WebPart_CatalogIconImageUrl="The URL of the image to be displayed in the catalog for the Web Part.";
	//WebPart_CantSetVisible="Cannot set the Visible property of a Web Part.  Use WebPartManager.AddWebPart() or WebPartManager.DeleteWebPart() instead.
	public const string WebPart_CantSetExportMode="Cannot set ExportMode after Load if not in shared mode or if there is no WebPartManager or if the WebPart is outside of a Zone.";
	public const string WebPart_DefaultImportErrorMessage="Cannot import this Web Part.";
	public const string WebPart_ErrorFormatString="{0} (Error)";
	public const string WebPart_ExportMode="Which properties can be exported from the Web Part.";
	public const string WebPart_HelpMode="Determines how the help page should be shown.";
	public const string WebPart_HelpUrl="The URL of the page that provides help for this Web Part.";
	public const string WebPart_Hidden="Whether the Web Part should be hidden on the page. A hidden Web Part can still be edited and participate in connections.";
	public const string WebPart_HiddenFormatString="(Hidden) {0}";
	public const string WebPart_ImportErrorInvalidVersion="The version of the imported <webPart /> is not supported.";
	public const string WebPart_ImportErrorMessage="The text shown when there is an error importing the Web Part.";
	public const string WebPart_ImportErrorNoVersion="The imported <webPart /> must specify its version using the xmlns attribute.";
	public const string WebPart_NonWebPart="The specified control is not being used as a Web Part.";
	public const string WebPart_NotStandalone="The {0} property cannot be set on Web Part '{1}', since it is a standalone Web Part.";
	public const string WebPart_OnlyStandalone="The {0} property cannot be set on Web Part '{1}'.  It can only be set on a standalone Web Part.";
	public const string WebPart_SetZoneTemplateTooLate="The ZoneTemplate property can only be set in or before the Page_PreInit event for static controls. For dynamic controls, set the property before adding it to the Controls collection.";
	public const string WebPart_TitleIconImageUrl="The URL of the image to be displayed in the title bar of the Web Part.";
	public const string WebPart_TitleUrl="The URL of the page that contains additional information about this Web Part.  The title of the Web Part will be rendered as a link to this page.";
	public const string WebPart_Collection_DuplicateID="A {0} has already been added with ID '{1}'.";
	public const string WebPartActionVerb_CantSetChecked="Cannot set the Checked property of this Verb.";
	public const string WebPartCatalogAddVerb_Description="Adds a Web Part to a Zone";
	public const string WebPartCatalogAddVerb_Text="Add";
	public const string WebPartCatalogCloseVerb_Description="Closes Catalog";
	public const string WebPartCatalogCloseVerb_Text="Close";
	public const string WebPartChrome_ConfirmExportSensitive="This Web Part Page has been personalized. As a result, one or more Web Part properties may contain confidential information. Make sure the properties contain information that is safe for others to read. After exporting this Web Part, view properties in the Web Part description file (.WebPart) by using a text editor such as Microsoft Notepad.";
	public const string WebPartCloseVerb_Description="Closes '{0}'";
	public const string WebPartCloseVerb_Text="Close";
	public const string WebPartConnectVerb_Description="Edits the connections for '{0}'";
	public const string WebPartConnectVerb_Text="Connect";
	public const string WebPartConnection_ConsumerIDNotSet="The ConsumerID property is not set.";
	public const string WebPartConnection_ConsumerRequiresSecondaryInterfaces="The consumer connection point '{0}' on '{1}' does not support a connection with no secondary interfaces, so it cannot be connected via a transformer.";
	public const string WebPartConnection_DisabledConnectionPoint="The connection point '{0}' on '{1}' is disabled.";
	public const string WebPartConnection_Duplicate="The connection point '{0}' on '{1}' does not allow multiple connections.";
	public const string WebPartConnection_IncompatibleConsumerTransformer="The transformer and the consumer connection point '{0}' on '{1}' do not use the same connection interface.";
	public const string WebPartConnection_IncompatibleConsumerTransformerWithType="The transformer of type '{0}' and the consumer connection point '{1}' on '{2}' do not use the same connection interface.";
	public const string WebPartConnection_IncompatibleProviderTransformer="The provider connection point '{0}' on '{1}' and the transformer do not use the same connection interface.";
	public const string WebPartConnection_IncompatibleProviderTransformerWithType="The provider connection point '{0}' on '{1}' and the transformer of type '{2}' do not use the same connection interface.";
	public const string WebPartConnection_IncompatibleSecondaryInterfaces="The consumer connection point '{0}' on '{1}' does not support connecting on the secondary interfaces provided by connection point '{2}' on '{3}'.";
	public const string WebPartConnection_NoCommonInterface="The provider connection point '{0}' on '{1}' and the consumer connection point '{2}' on '{3}' do not use the same connection interface.";
	public const string WebPartConnection_NoConsumer="Could not find the connection consumer Web Part with ID '{0}'.";
	public const string WebPartConnection_NoConsumerConnectionPoint="There is no consumer connection point '{0}' on '{1}'.";
	public const string WebPartConnection_NoID="Connection does not have an ID.";
	public const string WebPartConnection_NoProvider="Could not find the connection provider Web Part with ID '{0}'.";
	public const string WebPartConnection_NoProviderConnectionPoint="There is no provider connection point '{0}' on '{1}'.";
	public const string WebPartConnection_ProviderIDNotSet="The ProviderID property is not set.";
	public const string WebPartConnection_TransformerNotAvailable="The required transformer type is not allowed to be used on this page.";
	public const string WebPartConnection_TransformerNotAvailableWithType="The transformer type '{0}' is not allowed to be used on this page.";
	public const string WebPartConnectionsCancelVerb_Description="Cancels the current action";
	public const string WebPartConnectionsCancelVerb_Text="Cancel";
	public const string WebPartConnectionsCloseVerb_Description="Closes Connections Editor";
	public const string WebPartConnectionsCloseVerb_Text="Close";
	public const string WebPartConnectionsConfigureVerb_Description="Modifies the configuration of the connection";
	public const string WebPartConnectionsConfigureVerb_Text="Edit...";
	public const string WebPartConnectionsConnectVerb_Description="Connects the Web Parts";
	public const string WebPartConnectionsConnectVerb_Text="Connect";
	public const string WebPartConnectionsDisconnectVerb_Description="Disconnects the Web Parts";
	public const string WebPartConnectionsDisconnectVerb_Text="Disconnect";
	public const string WebPartDeleteVerb_Description="Deletes '{0}'";
	public const string WebPartDeleteVerb_Text="Delete";
	public const string WebPartDisplayModeCollection_CantRemove="Collection does not allow removal of items.";
	public const string WebPartDisplayModeCollection_CantSet="Collection does not allow setting of items.";
	public const string WebPartDisplayModeCollection_DuplicateName="A display mode has already been added with name '{0}'.";
	public const string WebPartEditorApplyVerb_Description="Applies changes";
	public const string WebPartEditorApplyVerb_Text="Apply";
	public const string WebPartEditorCancelVerb_Description="Cancels changes";
	public const string WebPartEditorCancelVerb_Text="Cancel";
	public const string WebPartEditorOKVerb_Description="Applies changes and closes editor";
	public const string WebPartEditorOKVerb_Text="OK";
	public const string WebPartEditVerb_Description="Edits '{0}'";
	public const string WebPartEditVerb_Text="Edit";
	public const string WebPartExportHandler_InvalidArgument="Invalid export parameters.";
	public const string WebPartExportHandler_DisabledExportHandler="Web Part export is currently disabled. It can be enabled by setting enableExport=""true" in the WebParts section of the configuration file for this application.";
	public const string WebPartExportVerb_Description="Exports the personalization data for '{0}' as an XML file";
	public const string WebPartExportVerb_Text="Export";
	public const string WebPartHeaderCloseVerb_Description="Closes Zone";
	public const string WebPartHeaderCloseVerb_Text="Close";
	public const string WebPartHelpVerb_Description="Shows help for '{0}'";
	public const string WebPartHelpVerb_Text="Help";
	//WebPartLinkVerb_Description="Exports '{0}' as a link on the desktop
	//WebPartLinkVerb_Text="Create Desktop Link
	//WebPartLinkHandler_Exception="Couldn't export web part {0} from page {1}
	//WebPartLinkHandler_InvalidArgument="Parameter {0} is missing from the query string.
	public const string WebPartManager_Personalization="The personalization settings associated with the WebPartManager and this page.";
	public const string WebPartManager_MustRegister="Zone must be registered with the WebPartManager.";
	public const string WebPartManager_UnknownConnection="Unknown connection.";
	public const string WebPartManager_AlreadyInConnect="Web part is already in connect mode.";
	public const string WebPartManager_AlreadyInZone="Web Part is already in a zone.";
	public const string WebPartManager_MustBeInConnect="Must be in connect mode.";
	public const string WebPartManager_AlreadyInEdit="Web part is already in edit mode.";
	public const string WebPartManager_MustBeInEdit="Must be in edit mode.";
	public const string WebPartManager_InvalidConnectionPoint="ConnectionPoint must be from a Web Part's ConnectionPoints collection.";
	public const string WebPartManager_NoSelectedWebPartConnect="No Web Part is having its connections changed.";
	public const string WebPartManager_NoSelectedWebPartEdit="No Web Part is being edited.";
	public const string WebPartManager_MustBeInZone="Web Part must be currently in a Zone.";
	public const string WebPartManager_OnlyOneInstance="Can only have one instance of a WebPartManager and it must precede any instances of WebPartZone controls.";
	public const string WebPartManager_AlreadyRegistered="Zone has already been registered.";
	public const string WebPartManager_NoZoneID="Zone does not have an ID.";
	public const string WebPartManager_DuplicateZoneID="A Zone has already been added with ID '{0}'.";
	public const string WebPartManager_CannotModify="Cannot directly modify the collection of Web Parts.  Instead, use the WebPartManager.AddWebPart() or WebPartManager.DeleteWebPart() method.";
	public const string WebPartManager_NoWebPartID="Web Part does not have an ID.";
	public const string WebPartManager_NoChildControlID="Child Control of Generic Web Part does not have an ID.";
	public const string WebPartManager_DuplicateWebPartID="A Web Part or Child Control of a Generic Web Part has already been added with ID '{0}'.";
	public const string WebPartManager_StaticConnections="The static connections between Web Parts on the page.";
	public const string WebPartManager_InvalidConsumerSignature="Method '{0}' on type '{1}' is not a valid connection consumer.  It must be public, return void, and take one parameter.";
	public const string WebPartManager_InvalidProviderSignature="Method '{0}' on type '{1}' is not a valid connection provider.  It must be public, return an object, and take no parameters.";
	public const string WebPartManager_ConnectTooLate="The ConnectWebParts method cannot be called after connections have already been activated (in WebPartManager.PreRender).";
	public const string WebPartManager_DisconnectTooLate="The DisconnectWebParts method cannot be called after connections have already been activated (in WebPartManager.PreRender).";
	public const string WebPartManager_EnableClientScript="Whether the client script features of the Web Part framework are enabled.";
	public const string WebPartManager_ForbiddenType="You are not allowed to use this Web Part.";
	//WebPartManager_TypeNotPublic="The type of the Web Part must be a public class.
	//WebPartManager_NoParameterlessConstructor="The type of the Web Part must contain a parameterless constructor.
	public const string WebPartManager_PartNotExportable="This part is not exportable. To be exportable, a part must be personalizable and not have its ExportMode set to None.";
	public const string WebPartManager_ImportInvalidFormat="The file format is not valid. Try importing a Web Part file (.WebPart).";
	public const string WebPartManager_ImportInvalidData="Couldn't import property {0}.";
	//WebPartManager_NotPersonalizable="The type specified is not personalizable.
	public const string WebPartManager_RegisterTooLate="The RegisterZone method cannot be called after the Page has been initialized.";
	public const string WebPartManager_ExportSensitiveDataWarning="The warning message to be displayed when potentially exporting sensitive personalized data.";
	public const string WebPartManager_AlreadyDisconnected="Connection has already been disconnected.";
	public const string WebPartManager_ConnectionsReadOnly="The Connections collection of WebPartManager is read-only.";
	public const string WebPartManager_DynamicConnectionsReadOnly="The DynamicConnections collection of WebPartManager is read-only after connections have been activated.";
	public const string WebPartManager_StaticConnectionsReadOnly="The StaticConnections collection of WebPartManager is read-only after connections have been activated.";
	public const string WebPartManager_DisplayModesReadOnly="The collection of DisplayModes on the WebPartManager is read-only.";
	//WebPartManager_AlreadyConnected="The Web Part '{0}' is already connected on the consumer connection point '{1}'.  You must delete the existing connection before creating a new connection.
	public const string WebPartManager_InvalidDisplayMode="The specified display mode is not supported on this page. Make sure personalization is enabled and the corresponding zones are present on the page. The display mode can be set during and after Page_Init.";
	public const string WebPartManager_DisabledDisplayMode="The specified display mode is currently disabled on this page. Make sure personalization is enabled for the current user.";
	public const string WebPartManager_CloseProviderWarning="The text shown to confirm closing a provider Web Part.";
	public const string WebPartManager_DefaultCloseProviderWarning="You are about to close this Web Part.  It is currently providing data to other Web Parts, and these connections will be deleted if this Web Part is closed.  To close this Web Part, click OK.  To keep this Web Part, click Cancel.";
	public const string WebPartManager_DeleteWarning="The text shown to confirm deleting a Web Part.";
	public const string WebPartManager_DefaultDeleteWarning="You are about to permanently delete this Web Part.  Are you sure you want to do this?  To delete this Web Part, click OK.  To keep this Web Part, click Cancel.";
	public const string WebPartManager_CantConnectClosed="Cannot create a new connection to closed Web Part '{0}'.";
	public const string WebPartManager_DuplicateConnectionID="A Connection has already been added with ID '{0}'.";
	public const string WebPartManager_AuthorizeWebPart="Raised to authorize a WebPart to be displayed in the page.";
	public const string WebPartManager_ConnectionsActivated="Raised after Connections have been activated.";
	public const string WebPartManager_ConnectionsActivating="Raised before Connections are activated.";
	public const string WebPartManager_DisplayModeChanged="Raised after the DisplayMode has been changed.";
	public const string WebPartManager_DisplayModeChanging="Raised before the DisplayMode is changed.";
	public const string WebPartManager_SelectedWebPartChanged="Raised after the SelectedWebPart has been changed.";
	public const string WebPartManager_SelectedWebPartChanging="Raised before the SelectedWebPart is changed.";
	public const string WebPartManager_WebPartAdded="Raised after a WebPart has been added.";
	public const string WebPartManager_WebPartAdding="Raised before a WebPart is added.";
	public const string WebPartManager_WebPartClosed="Raised after a WebPart has been closed.";
	public const string WebPartManager_WebPartClosing="Raised before a WebPart is closed.";
	public const string WebPartManager_WebPartDeleted="Raised after a WebPart has been deleted.";
	public const string WebPartManager_WebPartDeleting="Raised before a WebPart is deleted.";
	public const string WebPartManager_WebPartMoved="Raised after a WebPart has been moved.";
	public const string WebPartManager_WebPartMoving="Raised before a WebPart is moved.";
	public const string WebPartManager_WebPartsConnected="Raised after a new Connection has been established.";
	public const string WebPartManager_WebPartsConnecting="Raised before a new Connection is established.";
	public const string WebPartManager_WebPartsDisconnected="Raised after a Connection has been disconnected.";
	public const string WebPartManager_WebPartsDisconnecting="Raised before a Connection is disconnected.";
	public const string WebPartManager_CantDeleteStatic="Cannot delete a static Web Part.";
	public const string WebPartManager_CantDeleteSharedInUserScope="Cannot delete a shared Web Part in User personalization scope.";
	public const string WebPartManager_CantAddControlType="Cannot add a control of Type {0}.  The Type must be loadable by BuildManager.GetType(string typeName).";
	public const string WebPartManager_PathCannotBeEmpty="The "path" argument cannot be empty if the "type" argument is UserControl.";
	public const string WebPartManager_PathMustBeEmpty="The "path" argument must be empty if the "type" argument is not UserControl.  The "path" argument cannot be '{0}'.";
	//WebPartManager_ErrorWebPartTitle="Error
	public const string WebPartManager_CantCreateInstance="Could not create instance of the required type.";
	public const string WebPartManager_CantCreateInstanceWithType="Could not create instance of type '{0}'.";
	public const string WebPartManager_TypeMustDeriveFromControl="The type is not a subclass of Control.";
	public const string WebPartManager_TypeMustDeriveFromControlWithType="The type '{0}' is not a subclass of Control.";
	public const string WebPartManager_InvalidPath="Could not load the required path.";
	public const string WebPartManager_InvalidPathWithPath="Could not load path '{0}'.";
	public const string WebPartManager_CantCreateGeneric="Could not create GenericWebPart.";
	public const string WebPartManager_CantBeginConnectingClosed="Cannot begin connecting a closed WebPart.";
	public const string WebPartManager_CantBeginEditingClosed="Cannot begin editing a closed WebPart.";
	public const string WebPartManager_AlreadyClosed="Cannot close a closed WebPart.";
	public const string WebPartManager_CantSetEnableTheming="Cannot set the EnableTheming property on WebPartManager.  EnableTheming must be true for the WebParts to be themeable.";
	public const string WebPartManager_CantConnectToSelf="A WebPart cannot be connected to itself.";
	public const string WebPartManager_ErrorLoadingWebPartType="Could not load the required type.";
	public const string WebPartManagerRequired="You must enable Web Parts by adding a WebPartManager to your page.  The WebPartManager must be placed before any Web Part controls on the page.";
	public const string WebPartMenu_DefaultDropDownAlternateText="Verbs";
	//WebPartMenu_SeparatorAlternateText="------
	//WebPartMenuStyle_SeparatorColor="The color of the separators within the popup menu.
	public const string WebPartMenuStyle_ShadowColor="The color of the shadow below the popup menu.";
	public const string WebPartMinimizeVerb_Description="Minimizes '{0}'";
	public const string WebPartMinimizeVerb_Text="Minimize";
	public const string WebPartPersonalization_CannotLoadPersonalization="Personalization state could not be loaded by the selected personalization provider.";
	public const string WebPartPersonalization_CannotEnterSharedScope="Cannot toggle the page into shared personalization scope. The current user must be granted the right to enter shared personalization scope.";
	public const string WebPartPersonalization_CantCallMethodBeforeInit="The '{0}' method of '{1}' cannot be called before initialization of the page is complete.";
	public const string WebPartPersonalization_CantUsePropertyBeforeInit="The '{0}' property of '{1}' cannot be used before initialization of the page is complete.";
	public const string WebPartPersonalization_Enabled="Whether personalization of Web Parts is enabled.";
	public const string WebPartPersonalization_InitialScope="The initial PersonalizationScope to be used when the page is first requested.";
	public const string WebPartPersonalization_MustSetBeforeInit="The '{0}' property of '{1}' must be set before initialization of the page is complete.";
	public const string WebPartPersonalization_PersonalizationNotEnabled="Personalization is not enabled. The Enabled property must be set to true, a registered personalization provider must be selected, and initialization of the page must be complete.";
	public const string WebPartPersonalization_PersonalizationNotModifiable="Personalization is not enabled and/or modifiable. The Enabled property must be set to true, and a registered personalization provider must be selected. The current user must be granted the right to modify personalization state.";
	public const string WebPartPersonalization_PersonalizationStateNotLoaded="Personalization state has not been loaded.";
	public const string WebPartPersonalization_ProviderName="The name of a registered PersonalizationProvider used to access personalization state.";
	public const string WebPartPersonalization_ProviderNotFound="The specified personalization provider, '{0}', is not registered.";
	public const string WebPartPersonalization_SameType="'{0}' and '{1}' must be the same type.";
	public const string WebPartRestoreVerb_Description="Restores '{0}'";
	public const string WebPartRestoreVerb_Text="Restore";
	public const string WebPartTracker_CircularConnection="The ProviderConnectionPoint '{0}' is involved in a circular connection.";
	public const string WebPartVerb_Checked="Whether the verb is checked.  In a menu a checkmark would appear next to the verb text.";
	public const string WebPartVerb_Description="The description of the verb.  May be displayed in a tooltip.";
	public const string WebPartVerb_Enabled="Whether the verb is enabled.  A disabled verb will be shown but cannot be invoked.";
	public const string WebPartVerb_ImageUrl="The URL of the image to display for the verb.";
	public const string WebPartVerb_Text="The text to be displayed for the verb.";
	public const string WebPartVerb_Visible="Whether the verb is visible.";
	public const string WebPartZoneBase_AllowLayoutChange="Whether Web Parts can be added to, removed from, or moved within the Zone.";
	public const string WebPartZoneBase_CloseVerb="Verb to close a Web Part.";
	public const string WebPartZoneBase_ConnectVerb="Verb to edit the connections of a Web Part.";
	public const string WebPartZoneBase_CreateVerbs="Raised to add verbs to the Web Parts.";
	public const string WebPartZoneBase_DefaultEmptyZoneText="Add a Web Part to this zone by dropping it here.";
	public const string WebPartZoneBase_DeleteVerb="Verb to delete a Web Part.";
	public const string WebPartZoneBase_DisplayTitleFallback="Zone {0}";
	public const string WebPartZoneBase_DragHighlightColor="The color of the Zone's border when a Web Part is dragged over the Zone.";
	public const string WebPartZoneBase_EditVerb="Verb to edit a Web Part.";
	public const string WebPartZoneBase_ExportVerb="Verb to export a Web Part's personalization data.";
	public const string WebPartZoneBase_HelpVerb="Verb to show the help for a Web Part.";
	public const string WebPartZoneBase_LayoutOrientation="Specifies how the Web Parts are arranged within the Zone.";
	//WebPartZoneBase_LinkVerb="Verb to create a desktop link to a Web Part.
	public const string WebPartZoneBase_MenuPopupStyle="The style for the Verbs drop-down menu.";
	public const string WebPartZoneBase_MenuCheckImageStyle="The style for the checkmarks in the verbs menu.";
	public const string WebPartZoneBase_MenuCheckImageUrl="The image used to render the checkmarks in the verbs menu dropdown.";
	public const string WebPartZoneBase_MenuLabelHoverStyle="The mouse hover style for the verbs menu label.";
	public const string WebPartZoneBase_MenuLabelStyle="The style for the verbs menu label.";
	public const string WebPartZoneBase_MenuLabelText="The text for the verbs menu label.";
	public const string WebPartZoneBase_MenuPopupImageUrl="The image used to render the verbs menu popup.";
	public const string WebPartZoneBase_MenuVerbHoverStyle="The mouse hover style applied to the verbs within the menu popup.";
	public const string WebPartZoneBase_MenuVerbStyle="The style applied to the verbs within the menu popup.";
	public const string WebPartZoneBase_MinimizeVerb="Verb to minimize a Web Part.";
	public const string WebPartZoneBase_RestoreVerb="Verb to restore a Web Part.";
	public const string WebPartZoneBase_SelectedPartChromeStyle="The style applied to the chrome of the selected Web Part.";
	public const string WebPartZoneBase_ShowTitleIcons="Whether the icon of each Web Part should be displayed in its title bar.";
	public const string WebPartZoneBase_TitleBarVerbButtonType="The type of the verb buttons for each Web Part when rendered in the verb bar.";
	public const string WebPartZoneBase_TitleBarVerbStyle="The style applied to the verbs within the title bar.";
	//WebPartZoneBase_TitleSeparator="The string used to separate the Title and Caption of each Web Part.
	public const string WebPartZoneBase_WebPartVerbRenderMode="Specifies how the Web Part Verbs will be rendered.";
	public const string Zone_AddedTooLate="A Zone can only be added to the Page in or before the Page_Init event.";
	public const string Zone_EmptyZoneText="The text shown when the Zone is empty.";
	public const string Zone_EmptyZoneTextStyle="The style applied to the EmptyZoneText.";
	public const string Zone_ErrorStyle="The style applied to the error message shown in the Zone.";
	public const string Zone_FooterStyle="Style for the footer of the zone.";
	//Zone_HeaderAlignment="The horizontal alignment of the zone's header.
	public const string Zone_HeaderStyle="Style for the header of the zone.";
	public const string Zone_HeaderText="The text in the header of the zone.";
	public const string Zone_InvalidParent="A Zone may not be placed inside a Part or another Zone.";
	public const string Zone_Padding="The padding between Parts in the Zone.";
	public const string Zone_PartStyle="Style for the contained parts.";
	public const string Zone_PartChromePadding="Padding for the chrome of the contained parts.";
	public const string Zone_PartChromeStyle="Style for the chrome of the contained parts.";
	public const string Zone_PartChromeType="The type of chrome for the contained parts.";
	//Zone_PartTitleHorizontalAlign="The horizontal alignment of the titles of the contained parts.
	public const string Zone_PartTitleStyle="Style for the title bars of the contained parts.";
	public const string Zone_VerbButtonType="The type of the verb buttons.";
	public const string Zone_VerbStyle="The style applied to the verbs.";
	public const string Zone_SampleHeaderText="Zone Name";


	public const string PersonalizationAdmin_UnexpectedResetSharedStateReturnValue="Unexpected integer value '{0}' is returned when calling provider's ResetState method for resetting shared state with one path. The expected value should be either 0 or 1.";
	public const string PersonalizationAdmin_UnexpectedResetUserStateReturnValue="Unexpected integer value '{0}' is returned when calling provider's ResetState method for resetting user state with one path and one username. The expected value should be either 0 or 1.";
	public const string PersonalizationAdmin_UnexpectedPersonalizationProviderReturnValue="The negative value '{0}' is returned when calling provider's '{1}' method.  The method should return non-negative integer.";

	public const string PersonalizationStateInfoCollection_CouldNotAddSharedStateInfo="Error happened when adding a SharedPersonalizationStateInfo with Path '{0}' to the PersonalizationStateInfoCollection.";
	public const string PersonalizationStateInfoCollection_CouldNotAddUserStateInfo="Error happened when adding a UserPersonalizationStateInfo with Path '{0}' and Username '{1}' to the PersonalizationStateInfoCollection.";

	public const string PersonalizationStateQuery_IncorrectValueType="The query key '{0}' can only be set with value of type {1}.";

	public const string PersonalizationProviderHelper_CannotHaveCommaInString="Input parameter '{0}' cannot have comma in string value '{1}'.";
	public const string PersonalizationProviderHelper_Empty_Collection="Input parameter '{0}' cannot be an empty collection.";
	public const string PersonalizationProviderHelper_Invalid_Less_Than_Parameter="Input parameter '{0}' must be greater than or equal to {1}.";
	public const string PersonalizationProviderHelper_More_Than_One_Path="Input parameter '{0}' cannot contain more than one entry when '{1}' contains some entries.";
	public const string PersonalizationProviderHelper_Negative_Integer="The input parameter cannot be negative.";
	public const string PersonalizationProviderHelper_No_Usernames_Set_In_Shared_Scope="Input parameter '{0}' cannot be provided when '{1}' is set to '{2}'.";
	public const string PersonalizationProviderHelper_Null_Entries="Input parameter '{0}' cannot contain null entries.";
	public const string PersonalizationProviderHelper_Null_Or_Empty_String_Entries="Input parameter '{0}' cannot contain null or empty string entries.";
	public const string PersonalizationProviderHelper_TrimmedEmptyString="Input parameter '{0}' cannot be an empty string.";
	public const string PersonalizationProviderHelper_Trimmed_Entry_Value_Exceed_Maximum_Length="Trimmed entry value '{0}' of input parameter '{1}' cannot exceed character length {2}.";

#endif

#if false

	// StringUtil
	public const string StringUtil_Trimmed_String_Exceed_Maximum_Length="Trimmed string value '{0}' of input parameter '{1}' cannot exceed character length {2}.";

	// Web category attributes
	// (Indirectly referenced through the WebCategoryAttribute class)
	public const string Category_Accessibility="Accessibility";
	public const string Category_Cache="Cache";
	public const string Category_Control="Control";
	public const string Category_Databindings="Databindings";
	public const string Category_DefaultProperties="Default Properties";
	public const string Category_Links="Links";
	public const string Category_Navigation="Navigation";
	public const string Category_Paging="Paging";
	public const string Category_Parameter="Parameter";
	public const string Category_Styles="Styles";
	public const string Category_Validation="Validation";
	public const string Category_Verbs="Verbs";
	public const string Category_WebPart="Web Part";
	public const string Category_WebPartAppearance="Web Part Appearance";
	public const string Category_WebPartBehavior="Web Part Behavior";

	// Error Formatter text, generic to error pages
	public const string Error_Formatter_ASPNET_Error="Server Error in '{0}' Application.";
	public const string Error_Formatter_Description="Description:";

	public const string Error_Formatter_Source_File="Source File:";
	public const string Error_Formatter_No_Source_File="none";
	public const string Error_Formatter_Version="Version Information:";
	public const string Error_Formatter_CLR_Build="Microsoft .NET Framework Version:";
	public const string Error_Formatter_ASPNET_Build="; ASP.NET Version:";
	public const string Error_Formatter_Line="Line:";
	public const string Error_Formatter_FusionLog="Assembly Load Trace";
	public const string Error_Formatter_FusionLogDesc="The following information can be helpful to determine why the assembly '{0}' could not be loaded.";
	public const string Unhandled_Err_Error="Unhandled Execution Error";
	public const string Unhandled_Err_Desc="An unhandled exception occurred during the execution of the current web request. Please review the stack trace for more information about the error and where it originated in the code.\r\n";
	public const string Unhandled_Err_Exception_Details="Exception Details";
	public const string Unhandled_Err_Stack_Trace="Stack Trace";
	public const string Unauthorized_Err_Desc1="ASP.NET is not authorized to access the requested resource. Consider granting access rights to the resource to the ASP.NET request identity. ASP.NET has a base process identity (typically {MACHINE}\\ASPNET on IIS 5 or Network Service on IIS 6 and IIS 7, and the configured application pool identity on IIS 7.5) that is used if the application is not impersonating.  If the application is impersonating via <identity impersonate=""true"/>, the identity will be the anonymous user (typically IUSR_MACHINENAME) or the authenticated request user.";
	public const string Unauthorized_Err_Desc2="To grant ASP.NET access to a file, right-click the file in File Explorer, choose "Properties" and select the Security tab. Click "Add" to add the appropriate user or group. Highlight the ASP.NET account, and check the boxes for the desired access.";
	public const string Security_Err_Error="Security Exception";
	public const string Security_Err_Desc="The application attempted to perform an operation not allowed by the security policy.  To grant this application the required permission please contact your system administrator or change the application's trust level in the configuration file.";
	public const string NotFound_Resource_Not_Found="The resource cannot be found.";
	public const string NotFound_Http_404="HTTP 404. The resource you are looking for (or one of its dependencies) could have been removed, had its name changed, or is temporarily unavailable.  Please review the following URL and make sure that it is spelled correctly.";
	public const string NotFound_Requested_Url="Requested URL";
	public const string Forbidden_Type_Not_Served="This type of page is not served.";
	public const string Forbidden_Extension_Incorrect="The extension '{0}' may be incorrect.";
	public const string Forbidden_Extension_Desc="The type of page you have requested is not served because it has been explicitly forbidden.  {0}   Please review the URL below and make sure that it is spelled correctly.";
	public const string Generic_Err_Title="Runtime Error";
	public const string Generic_Err_Local_Desc="An application error occurred on the server. The current custom error settings for this application prevent the details of the application error from being viewed.";
	public const string Generic_Err_Remote_Desc="An application error occurred on the server. The current custom error settings for this application prevent the details of the application error from being viewed remotely (for security reasons). It could, however, be viewed by browsers running on the local server machine.";
	public const string Generic_Err_Details_Title="Details";
	public const string Generic_Err_Local_Details_Desc="To enable the details of this specific error message to be viewable on the local server machine, please create a <customErrors> tag within a "web.config" configuration file located in the root directory of the current web application. This <customErrors> tag should then have its "mode" attribute set to "RemoteOnly". To enable the details to be viewable on remote machines, please set "mode" to "Off".";
	public const string Generic_Err_Remote_Details_Desc="To enable the details of this specific error message to be viewable on remote machines, please create a <customErrors> tag within a "web.config" configuration file located in the root directory of the current web application. This <customErrors> tag should then have its "mode" attribute set to "Off".";
	public const string Generic_Err_Local_Details_Sample="<!-- Web.Config Configuration File -->\r\n\r\n<configuration>\r\n    <system.web>\r\n        <customErrors mode=""RemoteOnly"/>\r\n    </system.web>\r\n</configuration>";
	public const string Generic_Err_Remote_Details_Sample="<!-- Web.Config Configuration File -->\r\n\r\n<configuration>\r\n    <system.web>\r\n        <customErrors mode=""Off"/>\r\n    </system.web>\r\n</configuration>";
	public const string Generic_Err_Notes_Title="Notes";
	public const string Generic_Err_Notes_Desc="The current error page you are seeing can be replaced by a custom error page by modifying the "defaultRedirect" attribute of the application's <customErrors> configuration tag to point to a custom error page URL.";
	public const string Generic_Err_Local_Notes_Sample="<!-- Web.Config Configuration File -->\r\n\r\n<configuration>\r\n    <system.web>\r\n        <customErrors mode=""On" defaultRedirect=""mycustompage.htm"/>\r\n    </system.web>\r\n</configuration>";
	public const string Generic_Err_Remote_Notes_Sample="<!-- Web.Config Configuration File -->\r\n\r\n<configuration>\r\n    <system.web>\r\n        <customErrors mode=""RemoteOnly" defaultRedirect=""mycustompage.htm"/>\r\n    </system.web>\r\n</configuration>";
	public const string CustomErrorFailed_Err_Desc="An exception occurred while processing your request. Additionally, another exception occurred while executing the custom error page for the first exception. The request has been terminated.";
	public const string WithFile_No_Relevant_Line="[No relevant source lines]";
	public const string Src_not_available="The source code that generated this unhandled exception can only be shown when compiled in debug mode. To enable this, please follow one of the below steps, then request the URL:\r\n\r\n1. Add a "Debug="true" directive at the top of the file that generated the error. Example:\r\n\r\n{0}   <%@ Page Language=""C#" Debug=""true" %>{1}\r\n\r\nor:\r\n\r\n2) Add the following section to the configuration file of your application:\r\n\r\n{2}<configuration>\r\n    <system.web>\r\n        <compilation debug=""true"/>\r\n    </system.web>\r\n</configuration>{3}\r\n\r\n Note that this second technique will cause all files within a given application to be compiled in debug mode. The first technique will cause only that particular file to be compiled in debug mode.\r\n\r\nImportant: Running applications in debug mode does incur a memory/performance overhead. You should make sure that an application has debugging disabled before deploying into production scenario.";
	public const string Src_not_available_nodebug="An unhandled exception was generated during the execution of the current web request. Information regarding the origin and location of the exception can be identified using the exception stack trace below.";
	public const string WithFile_Line_Num="Line {0}:";
	public const string TmplCompilerErrorTitle="Compilation Error";
	public const string TmplCompilerErrorDesc="An error occurred during the compilation of a resource required to service this request. Please review the following specific error details and modify your source code appropriately.";
	public const string TmplCompilerCompleteOutput="Show Detailed Compiler Output";
	public const string TmplCompilerGeneratedFile="Show Complete Compilation Source";
	public const string TmplConfigurationAdditionalError="Show Additional Configuration Errors";

	public const string TmplCompilerErrorSecTitle="Compiler Error Message";
	public const string TmplCompilerFatalError="The compiler failed with error code {0}.";
	public const string TmplCompilerWarningBanner="Compiler Warning Messages";
	public const string TmplCompilerWarningSecTitle="Warning";
	public const string TmplCompilerSourceSecTitle="Source Error";
	public const string TmplCompilerSourceFileTitle="Source File";
	public const string TmplCompilerSourceFileLine="Line";
	public const string TmplCompilerLineHeader="Line {0}:";

	public const string Parser_Error="Parser Error";
	public const string Parser_Desc="An error occurred during the parsing of a resource required to service this request.   Please review the following specific parse error details and modify your source file appropriately.";
	public const string Parser_Error_Message="Parser Error Message";
	public const string Parser_Source_Error="Source Error";
	public const string Config_Error="Configuration Error";
	public const string Config_Desc="An error occurred during the processing of a configuration file required to service this request. Please review the specific error details below and modify your configuration file appropriately.";
	public const string File_Circular_Reference="{0} has a circular reference!";

	public const string CantGenPropertySet="Unable to generate code for a value of type '{1}'. This error occurred while trying to generate the property value for {0}.";

	// Trace strings
	public const string Trace_Request="Request";
	public const string Trace_Status_Code="Status Code";
	public const string Trace_Trace_Information="Trace Information";
	public const string Trace_Category="Category";
	public const string Trace_From_First="From First(s)";
	public const string Trace_Message="Message";
	public const string Trace_Warning="Warning";
	public const string Trace_From_Last="From Last(s)";
	public const string Trace_Control_Tree="Control Tree";
	public const string Trace_Control_Id="Control UniqueID";
	public const string Trace_Parent_Id="Parent Id";
	public const string Trace_Type="Type";
	public const string Trace_Viewstate_Size="ViewState Size";
	public const string Trace_Controlstate_Size="ControlState Size";
	public const string Trace_Render_Size="Render Size";
	public const string Trace_Session_State="Session State";
	public const string Trace_Application_State="Application State";
	public const string Trace_Request_Cookies_Collection="Request Cookies Collection";
	public const string Trace_Response_Cookies_Collection="Response Cookies Collection";
	public const string Trace_Headers_Collection="Headers Collection";
	public const string Trace_Response_Headers_Collection="Response Headers Collection";
	public const string Trace_Form_Collection="Form Collection";
	public const string Trace_Querystring_Collection="Querystring Collection";
	public const string Trace_Server_Variables="Server Variables";
	public const string Trace_Time_of_Request="Time of Request";
	public const string Trace_Url="URL";
	public const string Trace_Request_Type="Request Type";
	public const string Trace_Request_Encoding="Request Encoding";
	public const string Trace_Name="Name";
	public const string Trace_Value="Value";
	public const string Trace_Response_Encoding="Response Encoding";
	public const string Trace_Session_Id="Session Id";
	public const string Trace_No="No.";
	public const string Trace_Application_Key="Application Key";
	public const string Trace_Session_Key="Session Key";
	public const string Trace_Size="Size";
	public const string Trace_Request_Details="Request Details";
	public const string Trace_Application_Trace="<h1>Application Trace</h1>";
	public const string Trace_Clear_Current="clear current trace";
	public const string Trace_Physical_Directory="Physical Directory:";
	public const string Trace_Requests_This="Requests to this Application";
	public const string Trace_Remaining="Remaining:";
	public const string Trace_File="File";
	public const string Trace_Verb="Verb";
	public const string Trace_View_Details="View Details";
	public const string Trace_Render_Size_children="Render Size Bytes (including children)";
	public const string Trace_Viewstate_Size_Nochildren="ViewState Size Bytes (excluding children)";
	public const string Trace_Controlstate_Size_Nochildren="ControlState Size Bytes (excluding children)";
	public const string Trace_Page="Page";

	public const string Trace_Error_Title="Trace Error";
	public const string Trace_Error_LocalOnly_Description="The current trace settings prevent trace.axd from being viewed remotely (for security reasons).  It could, however, be viewed by browsers running on the local server machine.";
	public const string Trace_Error_LocalOnly_Details_Desc="To enable trace.axd to be viewable on remote machines, please create a <trace> tag within the configuration file located in the root directory of the current web application. This <trace> tag should then have its "localOnly" attribute set to "false".";
	public const string Trace_Error_LocalOnly_Details_Sample="<configuration>\r\n    <system.web>\r\n        <trace localOnly=""false"/>\r\n    </system.web>\r\n</configuration>";
	public const string Trace_Error_Enabled_Description="Trace.axd is not enabled in the configuration file for this application.  Note: Trace is never enabled when <deployment retail="true />";
	public const string Trace_Error_Enabled_Details_Desc="To enable trace.axd, please create a <trace> tag within the configuration file located in the root directory of the current web application.  This <trace> tag should then have its "enabled" attribute set to "true".";
	public const string Trace_Error_Enabled_Details_Sample="<configuration>\r\n    <system.web>\r\n        <trace enabled=""true"/>\r\n    </system.web>\r\n</configuration>";

	public const string WebPageTraceListener_Event="Event";

	// Adapters
	public const string Adapter_GoLabel="Go";
	public const string Adapter_OKLabel="OK";



	public const string MenuAdapter_Up="Up";
	public const string MenuAdapter_UpOneLevel="^Up One Level";
	public const string MenuAdapter_Expand="Expand {0}";

	public const string PageAdapter_MustHaveFormRunatServer="To adaptively render for this device, the page must have a form tag with runat="server.";
	public const string PageAdapter_RenderDelegateMustBeInServerForm="To adaptively render for this device, the delimiters <% %> or <%=" %> must be within a form element with runat="server.";


	// SQL Services
	public const string SQL_Services_Database_Empty_Or_Space_Only_Arg="The database name cannot be empty or contain only white space characters.";
	public const string SQL_Services_Cant_connect_sql_database="Unable to connect to SQL Server database.";
	public const string SQL_Services_Invalid_Feature="An invalid feature is requested.";
	public const string SQL_Services_Error_Deleting_Session_Job="The attempt to remove the Session State expired sessions job from msdb did not succeed.  This can occur either because the job no longer exists, or because the job was originally created with a different user account than the account that is currently performing the uninstall.  You will need to manually delete the Session State expired sessions job if it still exists."";
	public const string SQL_Services_Error_Executing_Command="An error occurred during the execution of the SQL file '{0}'. The SQL error number is {1} and the SqlException message is: {2}";
	public const string SQL_Services_Error_Cant_Uninstall_Nonempty_Table="Cannot uninstall the specified feature(s) because the SQL table '{0}' in the database '{1}' is not empty. You must first remove all rows from the table.";
	public const string SQL_Services_Error_Cant_Uninstall_Nonexisting_Database="Cannot uninstall the specified feature(s) because the SQL database '{0}' does not exist.";
	public const string SQL_Services_Error_Cant_use_custom_database="You cannot specify the database name because it is allowed only if the session state type is SessionStateType.Custom.";
	public const string SQL_Services_Error_missing_custom_database="The database name cannot be null or empty if the session state type is SessionStateType.Custom.";
	//SQL_Services_Error_custom_database_start_end_space="The custom database name cannot contain white space characters at the beginning or the end.
	public const string SQL_Services_Database_contains_invalid_chars="The custom database name cannot contain the following three characters: single quotation mark ('), left bracket ([) or right bracket (]).";

	// Provider Util
	public const string Provider_missing_attribute="The attribute '{0}' is missing in the configuration of the '{1}' provider.";
	public const string Invalid_provider_attribute="The value '{2}' specified for the attribute '{0}' is invalid in the configuration of the '{1}' provider.";
	public const string Invalid_mail_template_provider_attribute="The value '{2}' specified for the attribute '{0}' is invalid in the configuration of the '{1}' provider. Only application relative URLs (~/url) are allowed.";
	public const string Unexpected_provider_attribute="The attribute '{0}' is unexpected in the configuration of the '{1}' provider.";
	public const string Invalid_provider_positive_attributes="The attribute '{0}' is invalid in the configuration of the '{1}' provider. The attribute must be set to a non-negative integer.";
	public const string Invalid_provider_non_zero_positive_attributes="The attribute '{0}' is invalid in the configuration of the '{1}' provider. The attribute must be greater than zero.";

	// Health Monitoring
	//No_Health_Mon_Config_In_subdir="Health Monitoring configuration can only be set in machine or application configuration.
	//Duplicate_registered_provider="The provider '{0}' has already been registered.
	//No_provider_to_remove="No '{0}' provider to remove.
	//Duplicate_registered_event_type_name="The name '{0}' has already been registered in <healthEventNames> section.
	//Duplicate_registered_event_name="The name '{0}' has already been registered in <rules> section.
	//No_event_name_to_remove="No '{0}' event name to remove.
	//Duplicate_registered_profile="The profile name '{0}' has already been registered.
	//No_profile_to_remove="No '{0}' profile name to remove.
	//No_event_to_remove="No '{0}' event to remove.
	public const string Event_name_not_found="The event name '{0}' is not found.";
	public const string Event_name_invalid_code_range="The 'startEventCode' and 'endEventCode' attributes are invalid. 'startEventCode' must be equal or less than 'endEventCode'.";
	public const string Health_mon_profile_not_found="The profile '{0}' is not found.";
	public const string Health_mon_provider_not_found="The provider '{0}' is not found.";
	public const string Wmi_provider_cant_initialize="Cannot initialize WMI event provider. Error code:{0}.";
	//Health_mon_invalid_provider_name="The provider name '{0}' is invalid. Please note that a provider name cannot contain the illegal character ',' (comma).
	//Health_mon_invalid_event_name="The event name '{0}' is invalid.
	public const string Invalid_max_event_details_length="The value '{1}' specified for the maxEventDetailsLength attribute of the '{0}' provider is invalid. It should be between 0 and 1073741823.";
	//Duplicate_registered_buffer_mode="The buffer mode '{0}' has already been registered.
	//No_buffer_mode_to_remove="No '{0}' buffer mode to remove.
	public const string Health_mon_buffer_mode_not_found="The buffer mode '{0}' is not found.";
	public const string Invalid_attribute1_must_less_than_or_equal_attribute2="The value '{0}' specified for the {1} attribute must be less than or equal to the value '{2}' specified for the {3} attribute.";
	public const string Invalid_attribute1_must_less_than_attribute2="The value '{0}' specified for the {1} attribute must be less than the value '{2}' specified for the {3} attribute.";
	public const string MailWebEventProvider_discard_warning="{1} events were discarded since last notification was made at {2} because the event buffer capacity was exceeded. (Warning ID: {0})";
	public const string MailWebEventProvider_events_drop_warning="The {1} events remaining for this notification period will be discarded because the maximum number of messages allowed per notification was exceeded. (Warning ID: {0})";
	public const string MailWebEventProvider_summary_body="This message contains events {0} to {1} from the total of {2} events scheduled for this notification.  There were {3} events left in the buffer at the beginning of this notification.";
	public const string WebEvent_event_email_subject="Event Notification {0}, part {1}: {2}{3} event received in {4}";
	public const string WebEvent_event_group_email_subject="Event Notification {0}, part {1}: {2}{3} events received in {4}";
	public const string WebEvent_event_email_subject_template_error="Event Notification {0}, part {1}: {2}error in notification template";
	public const string MailWebEventProvider_Warnings="** Warnings **";
	public const string MailWebEventProvider_Summary="** Summary **";
	public const string MailWebEventProvider_Application_Info="** Application Information **";
	public const string MailWebEventProvider_Events="** Events **";
	public const string MailWebEventProvider_template_file_not_found_error="The template file to be used for creating this event notification is not found.  The {0} events that were part of this message were discarded.";
	public const string MailWebEventProvider_template_runtime_error="An unhandled exception occurred during the execution of the template page used to create this event notification.  The {0} events that were part of this message were discarded.";
	public const string MailWebEventProvider_template_compile_error="An error occurred during the compilation of the template page used to create this event notification.  The {0} events that were part of this notification were discarded.";
	public const string MailWebEventProvider_template_error_no_details="The current configuration prevents the exception details from being included in this message.  Add the "detailedTemplateErrors="true" attribute to the provider configuration to enable exception details to be reported.";
	public const string MailWebEventProvider_no_recipient_error="No recipients have been specified for the {0} instance named {1}.  If you would like to disable this provider, please remove it from the providers collection.";
	public const string Sql_webevent_provider_events_dropped="{0} events were discarded since last notification was made at {1} because the event buffer capacity was exceeded.";
	public const string MailWebEventProvider_cannot_send_mail="Unable to send out an e-mail to the SMTP server. Please ensure that the server specified in the <smtpMail> section is valid.";
	public const string Invalid_eventCode_error="The eventCode of a WebBaseEvent object must be a non-negative integer.";
	public const string Invalid_eventDetailCode_error="The eventDetailCode of a WebBaseEvent object must be a non-negative integer.";
	public const string System_eventCode_not_allowed="The event code {0} is invalid. Event codes less than {1} are reserved for ASP.NET.";
	public const string Event_log_provider_error="The EventLogWebEventProvider provider failed to log an event with the error code {0}.";
	public const string Wmi_provider_error="The WmiWebEventProvider provider failed to raise a WMI event with the error code {0}.";

	// Health Monitoring event messages
	public const string Webevent_msg_ApplicationStart="Application is starting.";
	public const string Webevent_msg_ApplicationShutdown="Application is shutting down.";
	public const string Webevent_msg_ApplicationCompilationStart="Application compilation is starting.";
	public const string Webevent_msg_ApplicationCompilationEnd="Application compilation finished.";
	public const string Webevent_msg_ApplicationHeartbeat="Application heartbeat.";
	public const string Webevent_msg_RequestTransactionComplete="Request transaction is complete.";
	public const string Webevent_msg_RequestTransactionAbort="Request transaction was aborted.";
	public const string Webevent_msg_RuntimeErrorRequestAbort="The request has been aborted.";
	public const string Webevent_msg_RuntimeErrorViewStateFailure="An error occurred while processing viewstate.";
	public const string Webevent_msg_RuntimeErrorValidationFailure="A validation error has occurred.";
	public const string Webevent_msg_RuntimeErrorPostTooLarge="Post size exceeded allowed limits.";
	public const string Webevent_msg_RuntimeErrorUnhandledException="An unhandled exception has occurred.";
	public const string Webevent_msg_RuntimeErrorWebResourceFailure_DecryptionError="An error occurred processing a web or script resource request. The resource identifier failed to decrypt.";
	public const string Webevent_msg_RuntimeErrorWebResourceFailure_ResourceMissing="An error occurred processing a web or script resource request. The requested resource '{0}' does not exist or there was a problem loading it.";
	public const string Webevent_msg_WebErrorParserError="A parser error has occurred.";
	public const string Webevent_msg_WebErrorCompilationError="A compilation error has occurred.";
	public const string Webevent_msg_WebErrorConfigurationError="A configuration error has occurred.";
	public const string Webevent_msg_AuditUnhandledSecurityException="An unhandled security exception has occurred.";
	public const string Webevent_msg_AuditInvalidViewStateFailure="Viewstate verification failed.";
	public const string Webevent_msg_AuditFormsAuthenticationSuccess="Forms authentication succeeded for the request.";
	public const string Webevent_msg_AuditUrlAuthorizationSuccess="URL authorization succeeded for the request.";
	public const string Webevent_msg_AuditFileAuthorizationFailure="File authorization failed for the request.";
	public const string Webevent_msg_AuditFormsAuthenticationFailure="Forms authentication failed for the request.";
	public const string Webevent_msg_AuditFileAuthorizationSuccess="File authorization succeeded for the request.";
	public const string Webevent_msg_AuditMembershipAuthenticationSuccess="Membership credential verification succeeded.";
	public const string Webevent_msg_AuditMembershipAuthenticationFailure="Membership credential verification failed.";
	public const string Webevent_msg_AuditUrlAuthorizationFailure="URL authorization failed for the request.";
	public const string Webevent_msg_AuditUnhandledAccessException="An unhandled access exception has occurred.";
	public const string Webevent_msg_OSF_Deserialization_String="A deserialization error occurred inside of ObjectStateFormatter.  Deserialization was attempted using a string TypeConverter.  The type of the property that failed to deserialize is '{0}'.";
	public const string Webevent_msg_OSF_Deserialization_Binary="A deserialization error occurred inside of ObjectStateFormatter.  Deserialization was attempted using binary serialization.";
	public const string Webevent_msg_OSF_Deserialization_Type="A deserialization error occurred inside of ObjectStateFormatter.  A property was typed as "Type" but the Type instance could not be created for '{0}'.";
	public const string Webevent_msg_Property_Deserialization="Deserialization of property '{0}' failed.  The serialization setting for this property was '{1}'.  The type of this property is currently defined as '{2}'.";


	// Health Monitoring detail event messages
	public const string Webevent_detail_ApplicationShutdownUnknown="Reason: Unknown.";
	public const string Webevent_detail_ApplicationShutdownHostingEnvironment="Reason: Hosting environment is shutting down.";
	public const string Webevent_detail_ApplicationShutdownChangeInGlobalAsax="Reason: Global.asax changed.";
	public const string Webevent_detail_ApplicationShutdownConfigurationChange="Reason: Configuration changed.";
	public const string Webevent_detail_ApplicationShutdownUnloadAppDomainCalled="Reason: Appdomain was explicitly unloaded.";
	public const string Webevent_detail_ApplicationShutdownChangeInSecurityPolicyFile="Reason: Security policy file changed.";
	public const string Webevent_detail_ApplicationShutdownBinDirChangeOrDirectoryRename="Reason: A subdirectory in the Bin application directory was changed or renamed.";
	public const string Webevent_detail_ApplicationShutdownBrowsersDirChangeOrDirectoryRename="Reason: A subdirectory in the Browsers application directory was changed or renamed.";
	public const string Webevent_detail_ApplicationShutdownCodeDirChangeOrDirectoryRename="Reason: A subdirectory in the Code application directory was changed or renamed.";
	public const string Webevent_detail_ApplicationShutdownResourcesDirChangeOrDirectoryRename="Reason: A subdirectory in the Resources application directory was changed or renamed.";
	public const string Webevent_detail_ApplicationShutdownIdleTimeout="Reason: The idle timeout was exceeded.";
	public const string Webevent_detail_ApplicationShutdownPhysicalApplicationPathChanged="Reason: The physical path of the application changed.";
	public const string Webevent_detail_ApplicationShutdownHttpRuntimeClose="Reason: HttpRuntime was explicitly closed.";
	public const string Webevent_detail_ApplicationShutdownInitializationError="Reason: Initialization error.";
	public const string Webevent_detail_ApplicationShutdownMaxRecompilationsReached="Reason: Maximum number of recompilations was reached.";
	public const string Webevent_detail_ApplicationShutdownBuildManagerChange="Reason: The BuildManager has made a change that requires the AppDomain to be shutdown.";
	public const string Webevent_detail_StateServerConnectionError="Reason: An error occurred while communicating with the state server.";
	public const string Webevent_detail_InvalidTicketFailure="Reason: The ticket supplied was invalid.";
	public const string Webevent_detail_ExpiredTicketFailure="Reason: The ticket supplied has expired.";
	public const string Webevent_detail_InvalidViewStateMac="Reason: The viewstate supplied failed integrity check.";
	public const string Webevent_detail_InvalidViewState="Reason: Viewstate was invalid.";
	public const string Webevent_detail_SqlProviderEventsDropped="Reason: Sql web event provider dropped events.";

	// WebEvent ToString
	public const string Webevent_event_code="Event code: {0}";
	public const string Webevent_event_message="Event message: {0}";
	public const string Webevent_event_time="Event time: {0}";
	public const string Webevent_event_time_Utc="Event time (UTC): {0}";
	public const string Webevent_event_sequence="Event sequence: {0}";
	public const string Webevent_event_occurrence="Event occurrence: {0}";
	public const string Webevent_event_id="Event ID: {0}";
	public const string Webevent_event_detail_code="Event detail code: {0}";
	public const string Webevent_event_process_information="Process information:";
	public const string Webevent_event_application_information="Application information:";
	public const string Webevent_event_process_statistics="Process statistics:";
	public const string Webevent_event_request_information="Request information:";
	public const string Webevent_event_exception_information="Exception information:";
	public const string Webevent_event_inner_exception_information="Inner exception information (level {0}):";
	public const string Webevent_event_exception_type="Exception type: {0}";
	public const string Webevent_event_exception_message="Exception message: {0}";
	public const string Webevent_event_thread_information="Thread information:";
	public const string Webevent_event_process_id="Process ID: {0}";
	public const string Webevent_event_process_name="Process name: {0}";
	public const string Webevent_event_account_name="Account name: {0}";
	public const string Webevent_event_machine_name="Machine name: {0}";
	public const string Webevent_event_application_domain="Application domain: {0}";
	public const string Webevent_event_trust_level="Trust level: {0}";
	public const string Webevent_event_application_virtual_path="Application Virtual Path: {0}";
	public const string Webevent_event_application_path="Application Path: {0}";
	public const string Webevent_event_request_url="Request URL: {0}";
	public const string Webevent_event_request_path="Request path: {0}";
	public const string Webevent_event_user="User: {0}";
	public const string Webevent_event_is_authenticated="Is authenticated: True";
	public const string Webevent_event_is_not_authenticated="Is authenticated: False";
	public const string Webevent_event_authentication_type="Authentication Type: {0}";
	public const string Webevent_event_process_start_time="Process start time: {0}";
	public const string Webevent_event_thread_count="Thread count: {0}";
	public const string Webevent_event_working_set="Working set: {0} bytes";
	public const string Webevent_event_peak_working_set="Peak working set: {0} bytes";
	public const string Webevent_event_managed_heap_size="Managed heap size: {0} bytes";
	public const string Webevent_event_application_domain_count="Application domain count: {0}";
	public const string Webevent_event_requests_executing="Requests executing: {0}";
	public const string Webevent_event_request_queued="Requests queued: {0}";
	public const string Webevent_event_request_rejected="Requests rejected: {0}";
	public const string Webevent_event_thread_id="Thread ID: {0}";
	public const string Webevent_event_thread_account_name="Thread account name: {0}";
	public const string Webevent_event_is_impersonating="Is impersonating: True";
	public const string Webevent_event_is_not_impersonating="Is impersonating: False";
	public const string Webevent_event_stack_trace="Stack trace: {0}";
	public const string Webevent_event_user_host_address="User host address: {0}";
	public const string Webevent_event_name_to_authenticate="Name to authenticate: {0}";
	public const string Webevent_event_custom_event_details="Custom event details: ";
	public const string Webevent_event_ViewStateException_information="ViewStateException information:";

	//ETW Events
	public const string Etw_Batch_Compilation="Batch compilation: {0} files.";
	public const string Etw_Success="success";
	public const string Etw_Failure="failure";

	//Error strings used by the ResX code we pull from fx\src\WinForms\Managed\System\Resources
	//These error strings are copied from fx\src\WinForms\Managed\system.windows.forms.txt
	//See DevDiv 9030 for a reference to this issue.
	//InvalidResXFile="Parse error parsing ResX file: {0}
	//InvalidResXFileReaderWriterTypes="Invalid ResX input.  Could not find valid "resheader" tags for the ResX reader and writer type names.
	//InvalidResXResourceNoName="Could not find a name for a resource.  The resource value was '{0}'.
	//InvocationException="The type {0} in the data at line {1}, position {2} could not be loaded because it threw the following exception during construction: {3}
	//NotSerializableType="An item named '{0}' of type '{1}' cannot be added to the resource file because it is not serializable.
	//NotSupported="The type {0} on line {1}, position {2} threw the following exception while being converted: {3}
	//ResXResourceWriterSaved="Resource writer has been saved.  You may not edit it.
	//SerializationException="The type {0} could not be read from the data in line {1}, position {2}.  The type's internal structure may have changed.  Either implement ISerializable on the type or provide a type converter that can provide a more reliable conversion format, such as text or an array of bytes.  The conversion exception was: {3}
	//TypeLoadException="The type {0} in the data at line {1}, position {2} could not be located.
	//TypeLoadExceptionShort="The type {0} could not be located.

	//IIS sections related
	public const string Config_collection_add_element_without_key="The element cannot be added to the collection because it has an empty key.";

	// Integrated Pipeline strings

	public const string Failed_Pipeline_Subscription="Event subscription failed for {0}";
	public const string Cant_Init_Native_Config="Unable to initialize the native configuration support external to the web worker process (HRESULT="0x{0}).\r\nnativerd.dll must be in %windir%\\system32\\inetsrv.";
	public const string Cant_Enumerate_NativeDirs="Unable to enumerate the application directories (HRESULT="0x{0}).";
	public const string Cant_Read_Native_Modules="An error occurred reading the integrated module list from system.webServer/modules. The error is 0x{0}.";
	public const string Cant_Create_Process_Host="An error occurred while initializing the default application domain.";
	public const string Invalid_AppDomain_Prot_Type="An occurred while trying to read and instantiate the configured AppDomainHandlerType.";
	public const string Invalid_Process_Prot_Type="An error occurred while trying to read and instantiate the configured ProcessHandlerType.";
	public const string Invalid_Application_Preload_Provider_Type="Preload provider '{0}' does not implement IProcessHostPreloadClient interface.";
	public const string Invalid_Enabled_Preload_Parameter="Application preload cannot be enabled when ApplicationPreloadUtil is not set.";
	public const string Failure_ApplicationPreloadUtil_Already_Set="ApplicationPreloadUtil has already been set.";
	public const string Failure_Create_Application_Preload_Provider_Type="An error occurred while trying to create preload provider '{0}'.";
	public const string Failure_Preload_Application_Initialization="An initialization error occurred while trying to preload an application.";
	public const string Failure_Calling_Preload_Provider="An error occurred while executing Preload method.";
	public const string Failure_Stop_Listener_Channel="An error occurred while trying to stop the process protocol listener channel.";
	public const string Failure_Stop_Process_Prot="An error occurred while trying to stop the process protocol handler.";
	public const string Failure_Start_AppDomain_Listener="An error occurred while trying to start an app domain protocol listener channel.";
	public const string Failure_Stop_AppDomain_Listener="An error occurred while trying to stop an app domain protocol listener channel.";
	public const string Failure_Stop_AppDomain_Protocol="An error occurred while trying to stop an app domain protocol handler.";
	public const string Failure_Start_Integrated_App="An error occurred while trying to start an integrated application instance.";
	public const string Failure_Stop_Integrated_App="An error occurred while trying to stop an integrated application instance.";
	public const string Failure_Shutdown_ProcessHost="An error occurred while trying to shutdown the process host.";
	public const string Failure_AppDomain_Enum="An error occurred while enumerating application domains.";
	public const string Failure_PMH_Ping="An error occurred during a process host ping.";
	public const string Failure_PMH_Idle="An error occurred during a process host idle check.";
	public const string Failure_Create_Listener_Shim="An error occurred while creating a dispatch shim in the target app domain.";
	public const string Event_Binding_Disallowed="Event handlers can only be bound to HttpApplication events during IHttpModule initialization.";
	public const string Requires_Iis_Integrated_Mode="This operation requires IIS integrated pipeline mode.";
	public const string Method_Not_Supported_By_Iis_Integrated_Mode="The {0} method is not supported by IIS integrated pipeline mode.";
	public const string Requires_Iis_7="This operation requires IIS version 7 or higher.";
	public const string Requires_Iis_75_Integrated="This operation requires IIS version 7.5 or higher running in integrated pipeline mode.";
	public const string Invalid_before_authentication="This method can only be called after the authentication event.";
	public const string Application_instance_cannot_be_changed="The application instance cannot be changed.";
	public const string Invalid_http_data_chunk="Output caching and response filtering are only compatible with memory and file based response buffers.  A native module in the pipeline has added an HTTP_DATA_CHUNK to the response that is not of type HttpDataChunkFromMemory or HttpDataChunkFromFileHandle.";
	public const string Substitution_blocks_cannot_be_modified="Post cache substitution is not compatible with modules in the IIS integrated pipeline that modify the response buffers.  Either a native module in the pipeline has modified an HTTP_DATA_CHUNK structure associated with a managed post cache substitution callback, or a managed filter has modified the response.";
	public const string TransferRequest_cannot_be_invoked_more_than_once="TransferRequest cannot be invoked more than once.";
	public const string Invoke_before_pipeline_event="'{0}' can only be invoked before '{1}' event is raised.";
	public const string Invalid_queue_limit="The value must be greater than zero.  A value of zero would disable the feature, but this can only be done via configuration.";
	public const string Queue_limit_is_zero="The value of '{0}' is currently zero, which means the feature is disabled.  To enable the feature, set the value to a positive integer in configuration.";

#endif

#if true

	// Routing strings
	public const string HttpMethodConstraint_ParameterValueMustBeString="The constraint for route parameter '{0}' on the route with URL '{1}' must have a string value in order to use an HttpMethodConstraint.";
	public const string Route_CannotHaveCatchAllInMultiSegment="A path segment that contains more than one section, such as a literal section or a parameter, cannot contain a catch-all parameter.";
	public const string Route_CannotHaveConsecutiveParameters="A path segment cannot contain two consecutive parameters. They must be separated by a '/' or by a literal string.";
	public const string Route_CannotHaveConsecutiveSeparators="The route URL separator character '/' cannot appear consecutively. It must be separated by either a parameter or a literal value.";
	public const string Route_CatchAllMustBeLast="A catch-all parameter can only appear as the last segment of the route URL.";
	public const string Route_InvalidParameterName="The route parameter name '{0}' is invalid. Route parameter names must be non-empty and cannot contain these characters: \"{{\", \"}}\", \"/\", \"?\"";
	public const string Route_InvalidRouteUrl="The route URL cannot start with a '/' or '~' character and it cannot contain a '?' character.";
	public const string Route_MismatchedParameter="There is an incomplete parameter in this path segment: '{0}'. Check that each '{{' character has a matching '}}' character.";
	public const string Route_RepeatedParameter="The route parameter name '{0}' appears more than one time in the URL.";
	public const string Route_ValidationMustBeStringOrCustomConstraint="The constraint entry '{0}' on the route with URL '{1}' must have a string value or be of a type which implements IRouteConstraint.";
	public const string RouteCollection_DuplicateEntry="The route provided already exists in the route collection. The collection may not contain duplicate routes.";
	public const string RouteCollection_DuplicateName="A route named '{0}' is already in the route collection. Route names must be unique.";
	public const string RouteCollection_NameNotFound="A route named '{0}' could not be found in the route collection.";
	public const string RouteCollection_RequiresContext="HttpContext.Current must be non-null when a RequestContext is not provided.";
	public const string RouteData_RequiredValue="The RouteData must contain an item named '{0}' with a non-empty string value.";
	public const string RouteTable_ContextMissingRequest="The context does not contain any request data.";
	public const string UrlRoutingHandler_NoRouteMatches="The incoming request does not match any route.";
	public const string UrlRoutingModule_NoHttpHandler="The route handler '{0}' did not return an IHttpHandler from its GetHttpHandler() method.";
	public const string UrlRoutingModule_NoRouteHandler="A RouteHandler must be specified for the selected route.";
	public const string RouteUrlExpression_InvalidExpression="Invalid expression, RouteUrlExpressionBuilder expects a string with format: RouteName=\"route\",Key1=\"Value1\",Key2=\"Value2\".";
	public const string PageRouteHandler_InvalidVirtualPath="VirtualPath must be a non-empty string starting with ~/.";
	public const string RouteParameter_RouteKey="The key to use from the route's values.";

#endif

#if false
	public const string Control_NotADescendentOfNamingContainer="This control is not a descendent of the NamingContainer of '{0}'.";

	public const string DynamicModuleRegistry_ModulesAlreadyInitialized="Cannot register a module after the application has been initialized.";
	public const string DynamicModuleRegistry_TypeIsNotIHttpModule="The type '{0}' is not an IHttpModule.";

	public const string StateApplication_FullTrustOnly="This type can only be used in a fully trusted application.";

	public const string HttpTaskAsyncHandler_CannotExecuteSynchronously="The handler '{0}' cannot be executed synchronously.";
	public const string SynchronizationContextUtil_AspCompatModeNotCompatible="<%@ Page AspCompat="\"true\" %> and <httpRuntime apartmentThreading="\"true\" /> are unsupported in the current application configuration.";
	public const string SynchronizationContextUtil_PageAsyncVoidMethodsNotCompatible="\"async void\" Page events are unsupported in the current application configuration.";
	public const string SynchronizationContextUtil_TaskReturningPageAsyncMethodsNotCompatible="Task-returning Page methods are unsupported in the current application configuration.";
	public const string SynchronizationContextUtil_PageAsyncTaskTimeoutHandlerParallelNotCompatible="Providing a non-null 'timeoutHandler' or a true 'executeInParallel' parameter value to the PageAsyncTask constructor is unsupported in the current application configuration.";
	public const string SynchronizationContextUtil_WebSocketsNotCompatible="WebSockets is unsupported in the current application configuration.";
	public const string SynchronizationContextUtil_UpgradeToTargetFramework45Instructions="To enable this, set the following configuration switch in Web.config:\r\n<system.web>\r\n  <httpRuntime targetFramework="\"4.5\" />\r\n</system.web>";
	public const string SynchronizationContextUtil_AddDowngradeAppSettingsSwitch="To work around this, add the following configuration switch in Web.config:\r\n<appSettings>\r\n  <add key=""aspnet:UseTaskFriendlySynchronizationContext" value=""false" />\r\n</appSettings>";
	public const string SynchronizationContextUtil_RemoveAppSettingsSwitch="To work around this, remove the following configuration switch in Web.config:\r\n<appSettings>\r\n  <add key=""aspnet:UseTaskFriendlySynchronizationContext" />\r\n</appSettings>";
	public const string SynchronizationContextUtil_ForMoreInformation="For more information, see http://go.microsoft.com/fwlink/?LinkId="252465.";
	public const string PageAsyncManager_CannotEnqueue="An asynchronous task cannot be queued at this time.";
	public const string TaskAsyncHelper_ParameterInvalid="The provided IAsyncResult is invalid.";

	public const string WebSockets_WebSocketModuleNotEnabled="The IIS WebSocket module is not enabled. For more information on enabling this module, please see http://go.microsoft.com/fwlink/?LinkId="231398.";
	public const string WebSockets_NotAWebSocketRequest="The incoming request is not a WebSocket request.";
	public const string WebSockets_OriginCheckFailed="This resource can only be accessed when requested by a page originating from the same authority.";
	public const string WebSockets_SubProtocolCannotBeNegotiated="The sub-protocol '{0}' cannot be negotiated for this request. See the WebSocketRequestedProtocols property for the list of sub-protocols that the client has indicated it can understand.";
	public const string WebSockets_AcceptWebSocketRequestCanOnlyBeCalledOnce="This method can only be called once per request.";
	public const string WebSockets_CannotBeCalledDuringBeginRequest="This method cannot be called during or before BeginRequest.";
	public const string WebSockets_CannotBeCalledAfterHandlerExecute="This method cannot be called after HttpContext.CurrentNotification has passed the ExecuteRequestHandler step.";
	public const string WebSockets_CannotBeCalledDuringChildExecute="This method cannot be called during a child request or from within the target of a TransferRequest.";
	public const string WebSockets_UnknownErrorWhileAccepting="Cannot accept the WebSocket request. An unknown error occurred.";
	public const string WebSockets_MethodNotAvailableDuringWebSocketProcessing="This method cannot be called once the request has fully transitioned to a WebSocket request.";
	public const string AspNetWebSocket_SendInProgress="A send operation is already in progress.";
	public const string AspNetWebSocket_SendMessageTypeInvalid="The outgoing message type must be WebSocketMessageType.Text or WebSocketMessageType.Binary.";
	public const string AspNetWebSocket_CloseAlreadySent="A close frame has already been sent to the remote endpoint.";
	public const string AspNetWebSocket_ReceiveInProgress="A receive operation is already in progress.";
	public const string AspNetWebSocket_CloseAlreadyReceived="A close frame has already been received from the remote endpoint.";
	public const string AspNetWebSocket_CloseStatusEmptyButCloseDescriptionNonNull="If a close status of WebSocketCloseStatus.Empty is specified, the provided status description must be null or empty.";
	public const string AspNetWebSocket_CloseDescriptionTooLong="The close status description is too long. Its UTF8-encoded representation must be {0} bytes or fewer.";
	public const string AspNetWebSocket_DisposeNotSupported="WebSocket instances cannot be disposed because applications do not control the lifetime of these objects.";

	//ModelBinding Resources
	public const string Common_NullOrEmpty="Value cannot be null or empty.";
	public const string Common_PropertyCannotBeNullOrEmpty="The property '{0}' cannot be null or empty.";
	public const string ValueProviderResult_ConversionThrew="The parameter conversion from type '{0}' to type '{1}' failed. See the inner exception for more information.";
	public const string ValueProviderResult_NoConverterExists="The parameter conversion from type '{0}' to type '{1}' failed because no type converter can convert between these types.";
	public const string Common_PropertyNotFound="The property {0}.{1} could not be found.";
	public const string DataAnnotationsModelMetadataProvider_UnknownProperty="{0} has a DisplayColumn attribute for {1}, but property {1} does not exist.";
	public const string DataAnnotationsModelMetadataProvider_UnreadableProperty="{0} has a DisplayColumn attribute for {1}, but property {1} does not have a public getter.";
	public const string Common_TypeMustDriveFromType="The type {0} must derive from {1}";
	public const string DataAnnotationsModelValidatorProvider_ConstructorRequirements="The type {0} must have a public constructor that accepts three parameters of types {1}, {2}, and {3}";
	public const string ClientDataTypeModelValidatorProvider_FieldMustBeNumeric="The field {0} must be a number.";
	public const string DataAnnotationsModelValidatorProvider_ValidatableConstructorRequirements="The type {0} must have a public constructor that accepts two parameters of types {1} and {2}";
	public const string ValidatableObjectAdapter_IncompatibleType="The model object inside the metadata claimed to be compatible with {0}, but was actually {1}.";
	public const string BindingBehavior_ValueNotFound="A value for '{0}' is required but is not present in the request.";
	public const string Common_TypeMustImplementInterface="The type '{0}' does not implement the interface '{1}'.";
	public const string GenericModelBinderProvider_ParameterMustSpecifyOpenGenericType="The type '{0}' is not an open generic type.";
	public const string GenericModelBinderProvider_TypeArgumentCountMismatch="The open model type '{0}' has {1} generic type argument(s), but the open binder type '{2}' has {3} generic type argument(s). The binder type must not be an open generic type or must have the same number of generic arguments as the open model type.";
	public const string ModelBinderConfig_ValueInvalid="The value '{0}' is not valid for {1}.";
	public const string ModelBinderConfig_ValueRequired="A value is required.";
	public const string ModelBinderProviderCollection_BinderForTypeNotFound="A binder for type {0} could not be located.";
	public const string ModelBinderProviderCollection_InvalidBinderType="The type '{0}' does not subclass {1} or implement the interface {2}.";
	public const string ModelBinderUtil_ModelCannotBeNull="The binding context has a null Model, but this binder requires a non-null model of type '{0}'.";
	public const string ModelBinderUtil_ModelInstanceIsWrong="The binding context has a Model of type '{0}', but this binder can only operate on models of type '{1}'.";
	public const string ModelBinderUtil_ModelMetadataCannotBeNull="The binding context cannot have a null ModelMetadata.";
	public const string ModelBinderUtil_ModelTypeIsWrong="The binding context has a ModelType of '{0}', but this binder can only operate on models of type '{1}'.";
	public const string ModelBindingContext_ModelMetadataMustBeSet="The ModelMetadata property must be set before accessing this property.";

	//AppVerifier Resources
	public const string AppVerifier_Title="ASP.NET Runtime Verification Assertion Failure";
	public const string AppVerifier_Subtitle="ASP.NET detected an error while invoking an asynchronous method. Details of the error are provided below to help diagnose the problem.";
	public const string AppVerifier_BasicInfo_URL="Current URL: {0}";
	public const string AppVerifier_BasicInfo_ErrorCode="Error code: {0}";
	public const string AppVerifier_BasicInfo_Description="Description: {0}";
	public const string AppVerifier_BasicInfo_ThreadInfo="The assertion was triggered on thread {0} at {1} with the following stack trace:";
	public const string AppVerifier_BeginMethodInfo_EntryMethod="Entry point which triggered failure: {0}";
	public const string AppVerifier_BeginMethodInfo_RequestNotification_Integrated="Request notification at time of entry: {0} [IsPostNotification =" {1}]";
	public const string AppVerifier_BeginMethodInfo_RequestNotification_NotIntegrated="Request notification at time of entry: n/a (not running in integrated mode)";
	public const string AppVerifier_BeginMethodInfo_CurrentHandler="Request handler at time of entry: {0}";
	public const string AppVerifier_BeginMethodInfo_ThreadInfo="The entry point was invoked on thread {0} at {1} with the following stack trace:";
	public const string AppVerifier_AsyncCallbackInfo_InvocationCount="AsyncCallback was invoked a total of {0} time(s).";
	public const string AppVerifier_AsyncCallbackInfo_FirstInvocation_ThreadInfo="It was first invoked on thread {0} at {1} with the following stack trace:";
	public const string AppVerifier_Errors_HttpApplicationInstanceWasNull="The provided HttpApplication instance was null. The HttpApplication instance must be non-null.";
	public const string AppVerifier_Errors_BeginHandlerDelegateWasNull="The provided entry point (BeginHandler) was null. The entry point must be non-null.";
	public const string AppVerifier_Errors_AsyncCallbackInvokedMultipleTimes="AsyncCallback has already been invoked. The callback must never be invoked multiple times.";
	public const string AppVerifier_Errors_AsyncCallbackInvokedWithNullParameter="AsyncCallback was invoked with a null IAsyncResult argument. The callback must be given a non-null argument.";
	public const string AppVerifier_Errors_AsyncCallbackGivenAsyncResultWhichWasNotCompleted="AsyncCallback was invoked with an IAsyncResult which was marked 'IsCompleted =" false'. The callback must not be invoked until the asynchronous operation has completed.";
	public const string AppVerifier_Errors_AsyncCallbackInvokedAsynchronouslyButAsyncResultWasMarkedCompletedSynchronously="AsyncCallback was invoked asynchronously, but the provided IAsyncResult argument was marked 'CompletedSynchronously =" true'. The argument's CompletedSynchronously property must match the manner in which the asynchronous operation completed.";
	public const string AppVerifier_Errors_AsyncCallbackInvokedSynchronouslyButAsyncResultWasNotMarkedCompletedSynchronously="AsyncCallback was invoked synchronously, but the provided IAsyncResult argument was marked 'CompletedSynchronously =" false'. The argument's CompletedSynchronously property must match the manner in which the asynchronous operation completed.";
	public const string AppVerifier_Errors_AsyncCallbackInvokedWithUnexpectedAsyncResultInstance="The entry point returned an IAsyncResult instance other than the IAsyncResult argument provided to AsyncCallback. The entry point's return value must match the argument provided to AsyncCallback.";
	public const string AppVerifier_Errors_AsyncCallbackInvokedEvenThoughBeginHandlerThrew="AsyncCallback was invoked even though the entry point threw an exception. AsyncCallback should not be invoked if the entry point throws an exception.";
	public const string AppVerifier_Errors_AsyncCallbackInvokedWithUnexpectedAsyncResultAsyncState="The IAsyncResult argument passed to AsyncCallback had an invalid AsyncState property. The IAsyncResult's AsyncState property must match the state object parameter provided to the entry point.";
	public const string AppVerifier_Errors_AsyncCallbackCalledAfterHttpApplicationReassigned="The underlying HTTP request had already completed by the time AsyncCallback was invoked asynchronously.";
	public const string AppVerifier_Errors_BeginHandlerReturnedNull="The entry point returned a null value. The return value must be a non-null IAsyncResult instance.";
	public const string AppVerifier_Errors_BeginHandlerReturnedAsyncResultMarkedCompletedSynchronouslyButWhichWasNotCompleted="The entry point returned an IAsyncResult instance that was marked 'CompletedSynchronously =" true' and 'IsCompleted =" false'. If the operation is completed, it must be marked 'IsCompleted =" true'.";
	public const string AppVerifier_Errors_BeginHandlerReturnedAsyncResultMarkedCompletedSynchronouslyButAsyncCallbackNeverCalled="The entry point returned an IAsyncResult instance that was marked 'CompletedSynchronously =" true', but AsyncCallback was never invoked synchronously. If an operation completes synchronously and AsyncCallback is non-null, the callback must be invoked synchronously before the entry point returns to its caller.";
	public const string AppVerifier_Errors_BeginHandlerReturnedUnexpectedAsyncResultAsyncState="The entry point returned an IAsyncResult instance with an invalid AsyncState property. The IAsyncResult's AsyncState property must match the state object parameter provided to the entry point.";
	public const string AppVerifier_Errors_SyncContextSendOrPostCalledAfterRequestCompleted="A thread attempted to call SynchronizationContext.Send or SynchronizationContext.Post after the request associated with the SynchronizationContext had already completed.";

#endif

}
