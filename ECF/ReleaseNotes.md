This Wiki page lists notes for CEF releases.

**Note to Editors: Changes made to this Wiki page without prior approval via the [CEF Forum](http://magpcss.org/ceforum/) or[ Issue Tracker](https://bitbucket.org/chromiumembedded/cef/issues?status=new&status=open) may be lost or reverted.**

***

**This page is deprecated and will no longer be updated. View the [Commits list](https://bitbucket.org/chromiumembedded/cef/commits/branch/master) to see the complete list of revisions included in automated branch builds available from [http://cefbuilds.com](http://cefbuilds.com).**

Not all revisions are listed here. View the [Commits list](https://bitbucket.org/chromiumembedded/cef/commits/branch/master) to see the complete list of revisions.

**January 27, 2015:** Version 3.2171.1979 for Windows, Mac OS X and Linux includes the following enhancements and bug fixes.

  * Update to Chromium version 39.0.2171.95
  * Add spell checking support (issue #137).
  * Remove the CefBrowserHost::ParentWindowWillClose method that was added for modal dialog support but never implemented (issue #519).
  * Add support for DevTools inspect element via a new |inspect\_element\_at| parameter added to CefBrowserHost::ShowDevTools (issue #586).
  * Linux: Fix crash due to Chromium modifying the |argv| passed to main() (issue #620).
  * Windows: Fix assertion on shutdown when using multi-threaded-message-loop mode (issue #755).
  * Remove CefDOMEvent and CefDOMEventListener which are no longer supported by Chromium (issue #933).
  * Windows/Linux: Fix positioning of select popups and dismissal on window move/resize by calling new CefBrowserHost::NotifyMoveOrResizeStarted() method from client applications (issue #1208).
  * Fix CefBrowser::GetFrameIdentifiers and GetFrameNames to return correct values in the renderer process (issue #1236).
  * Re-implement off-screen rendering using the new delegated rendering approach (issue #1257). This implementation supports both GPU compositing and software compositing (used when GPU is not supported or when passing `--disable-gpu --disable-gpu-compositing` command-line flags). GPU-accelerated features (WebGL and 3D CSS) that did not work with the previous off-screen rendering implementation do work with this implementation when GPU support is available.
  * Linux: Remove GTK+ dependency from libcef and switch to Aura/X11 implementation (issue #1258).
  * Fix configuration of the User-Agent string during startup (issue #1275).
  * Fix execution of OnBeforePluginLoad (issue #1284).
  * Fix delivery of focus/blur events (issue #1301).
  * Mac: Fix flash on resize (issue #1307).
  * Bundle pepper PDF plugin on all platforms (issue #1331). The new pdf.dll is also required on Windows for printing.
  * Move scaled resources from cef.pak into separate cef\_100\_percent.pak and cef\_200\_percent.pak files (issue #1331).
  * Introduce the use of Chromium types in a new include/base folder (issue #1336). See associated changes in cefclient/cefsimple.
  * Windows: Add wow\_helper.exe to the 32-bit binary distribution for Vista 64-bit sandbox support (issue #1366).
  * Reduce resource usage when the window is minimized (issue #1369). See associated changes in cefclient/cefsimple.
  * Fix identification of the focused frame (issue #1381).
  * Mac: Add NSSupportsAutomaticGraphicsSwitching to Info.plist so that the GPU is only triggered when needed (issue #1396).
  * Call OnTitleChange after navigation/reload even if the title has not changed (issue #1441).
  * Add CefBrowserHost::GetNavigationEntries for retrieving a snapshot of navigation history (issue #1442).
  * Pass cursor type and custom cursor information to CefRenderHandler::OnCursorChange (issue #1443).
  * Linux: Fix "No URLRequestContext for NSS HTTP handler" error (issue #1490).

**June 12, 2014:** Version 3.1750.1738 for Windows, Mac OS X and Linux includes the following enhancements and bug fixes.

  * Update to Chromium version 33.0.1750.170
  * Add the cefsimple sample application which demonstrates the minimal functionality required to create a browser window.
  * Windows: Switch to aura/views architecture for content window creation (issue #180).
  * Windows: Support non-ASCII paths for CefStream file access (issue #481).
  * Add sandbox support (issue #524).
    * The sandbox is now enabled by default on all platforms. Use the CefSettings.no\_sandbox option or the "no-sandbox" command-line flag to disable sandbox support.
    * Windows: See cef\_sandbox\_win.h for requirements to enable sandbox support and usage of CEF\_ENABLE\_SANDBOX define in cefclient/cefsimple.
    * Windows: If Visual Studio isn't installed in the standard location set the CEF\_VCVARS environment variable before running make\_distrib.py or automate.py (see msvs\_env.bat).
    * Linux: For binary distributions a new chrome-sandbox executable with SUID permissions must be placed next to the CEF executable. See https://code.google.com/p/chromium/wiki/LinuxSUIDSandboxDevelopment for details on setting up the development environment when building CEF from source code.
  * Support DevTools without remote debugging via CefBrowserHost::ShowDevTools and CloseDevTools methods (issue #659).
  * Fix crash when using asynchronous continuation with a custom resource handler (issue #1066).
  * Windows: Support building with Visual Studio 2013 (issue #1094).
  * Add a CefGetMimeType function for retrieving the mime type of a file extension (issue #1098).
  * Enable print option in context menu (issue #1127).
  * Add breakpad support (issue #1131).
    * General usage instructions are available at https://sites.google.com/a/chromium.org/dev/developers/testing/webkit-layout-tests/using-breakpad-with-content-shell.
    * Mac: Generate "Chromium Embedded Framework.framework" using a new cef\_framework target (the libcef target is now only used on Windows and Linux). Rename "Libraries/libcef.dylib" to "Chromium Embedded Framework". Distribute Release and Debug builds of the "Chromium Embedded Framework.framework" folder as part of the binary distribution.
    * Mac: Fix the Xcode target compiler setting for the binary distribution so that it no longer needs to be set manually.
  * Remove the built-in about:tracing UI (issue #1146). Traces generated with CEF can be loaded in Google Chrome about:tracing.
  * Fix C compiler errors when using the C API (issue #1165).
  * Provide a generic JavaScript message router implementation (issue #1183).
  * Add MayBlock() method to stream classes which is used as a hint when determining the thread to access the stream from (issue #1187).
  * Mac: Change shutdown-related code to match Chromium (issue #1203)
  * Fix delivery of focus/blur events (issue #1301)

**January 13, 2014:** Version 3.1650.1562 for Windows, Mac OS X and Linux includes the following enhancements and bug fixes.

  * Update to Chromium version 31.0.1650.57
  * Add support for printing via CefBrowserHost::Print() and JavaScript window.print() (issue #505).
  * Add search/find support via CefBrowserHost::Find (issue #513).
  * Fix assignment of log file path (issue #903).
  * Make CefURLRequest::GetResponse() data available before download completion (issue #956).
  * Add CefURLRequestClient::GetAuthCredentials callback (issue #975).
  * Support file uploads in CefURLRequests originating from the browser process (issue #1013).
  * Fix memory corruption in browser-initiated CefURLRequests (issue #1118).
  * Add new CefRequestContext and CefRequestContextHandler classes (issue #1044).
  * Add CefRequestContext argument to CefBrowserHost static factory methods (issue #1044).
  * Move GetCookieManager from CefRequestHandler to CefRequestContextHandler (issue #1044).
  * Fix loading of popup windows with a newly created render process (issue #1057).
  * Expose resource type and transition type via CefRequest (issue #1071).
  * Add CefRequestHandler::OnBeforeBrowse callback (issue #1076).
  * Expose CefLoadHandler in the render process (issue #1077).
  * Fix loading of DevTools frontend from chrome-devtools scheme (issue #1095).
  * Fix a crash when closing an off-screen browser with no references (issue #1121).
  * Set "User-Agent" and "Accept-Language" headers for requests sent using CefURLRequest (issue #1125).
  * Fix crash when browser window creation is canceled (issue #1147).
  * Linux: Apply system font settings (issue #1148).
  * Linux: Honor the CefSettings.product\_version setting (issue #1149).
  * Allow customization of default background color (issue #1161).

**August 23, 2013:** Version 3.1547.1412 for Windows, Mac OS X and Linux includes the following enhancements and bug fixes.

  * Update to Chromium version 29.0.1547.59.
  * Introduce 64-bit builds for Windows and Mac OS X.
  * Windows: Add CefSetOSModalLoop function to improve native menu responsiveness (issue #194).
  * Linux: Add off-screen rendering support (issue #518).
  * Force flash and silverlight plugins to windowless mode when using off-screen rendering (issue #518).
  * Add support for CefDragHandler::OnDragEnter (issue #601).
  * Mac: Don't create extra Helper folders in the app bundle (issue #806).
  * Reduce locking in browser and frame implementations to avoid potential deadlocks (issue #824).
  * Add CefRenderHandler::OnScrollOffsetChanged callback (issue #889).
  * Add CefJSDialogHandler::OnDialogClosed callback (issue #943).
  * Add additional V8 performance tests (issue #960).
  * Fix keyboard handling for popups when using off-screen rendering (issue #962).
  * Use scoped class to implement CEF\_TRACE\_EVENTx (issue #971).
  * Mac: Add IME support for off-screen rendering (issue #973)
  * Linux: Force use of the sub-process executable path for the zygote process (issue #980).
  * Mac: Improve scroll event handling for the cefclient off-screen rendering example (issue #982).
  * Add a password argument to CefZipArchive::Load (issue #986).
  * Use chrome translations for most context menu strings (issue #992).
  * Improve V8 memory management and performance (issue #1001).
  * Linux: Include the libffmpegsumo.so library in binary distributions (issue #1003).
  * Windows: Force child processes to exit on main process termination (issue #1011).
  * Fix problem routing messages to CEF network-related callbacks (issue #1012).
  * Mac: Fix crash on 10.6 and older 10.7 versions when building with the 10.7 SDK (issue #1026).
  * Mac: Support retina display when building with the 10.6 SDK (issue #1038).

**May 9, 2013:** Version 3.1453.1255 for Windows, Mac OS X and Linux 64-bit includes the following enhancements and bug fixes.

  * Update to Chromium version 27.0.1453.73.
  * Add CefRequestHandler::OnCertificateError() callback (issue #345).
  * Remove V8 worker bindings (issue #451).
  * Mac: Add off-screen rendering support (issue #518).
  * Fix WebRTC support (issue #531).
  * Add support for x-webkit-speech (issue #758).
  * Change the way that application shutdown works in order to support JavaScript 'onbeforeunload' handling (issue #853). See comments in cef\_life\_span\_handler.h for a detailed description of the new shutdown process.
  * Add CefBrowserHost::SetMouseCursorChangeDisabled() method for disabling mouse cursor changes (issue #884).
  * Add new CefNowFromSystemTraceTime() method (issue #908).
  * Add CefBrowserHost::WasHidden() method for notifying a windowless browser that it has been hidden or shown (issue #909).
  * Use a platform API hash instead of build revision for checking libcef compatibility (issue #914).
  * Add support for the V8 LoadTimes extension (issue #917).
  * Support cross-origin XMLHttpRequest loads and redirects for custom standard schemes when enabled via the cross-origin whitelist (issue #950).
  * cefclient: Simplify and streamline the cefclient sample application.
  * cefclient: Enable DevTools by default.
  * cefclient: Resolve make build issues with the Linux binary distribution.
  * Introduce a new download organization with separate archives for documentation, distributions and the cefclient sample application.

**April 8, 2013:** Version 3.1364.1188 is the first binary release for 32-bit and 64-bit Linux. In addition to the changes described below for version 3.1364.1094 it includes the following enhancements and bug fixes.

  * Add the ability to persist session cookies (issue #881).
  * Add a new CefBrowserHost::StartDownload method for starting a download that can then be handled via CefDownloadHandler (issue #883)
  * Add new CefSettings.ignore\_certificate\_errors option to ignore errors related to invalid SSL certificates (issue #345).
  * cefclient: Add example of window manipulation via JavaScript (issue #925).

**March 4, 2013:** Version 1.1364.1123 contains the following enhancements and bug fixes.

  * Update to Chromium version 25.0.1364.152.
  * Mac: OS-X 10.5 (Leopard) is no longer supported.
  * Default Google API keys for geolocation are no longer supported. Register for custom API keys as described [here](http://www.chromium.org/developers/how-tos/api-keys).
  * Windows: Add new CefSetOSModalLoop function to improve menu responsiveness (issue #194).
  * Allow empty |mimeType| argument to GetDownloadHandler (issue #405).
  * Support implicit detachment of CEF V8 references when the associated context is released (issue #484).
  * Reduce persistent CEF V8 memory usage by tracking objects on a per-context basis and not persisting objects when the underlying V8 handle is unused (issue #484).
  * cefclient: Add performance tests for CEF V8 methods (issue #484).
  * Mac: cefclient: Call makeFirstResponder:nil from windowDidResignKey: to remove focus from the browser view when the window becomes inactive (issue #565).
  * Add CefApp::OnRegisterCustomSchemes callback to address url\_util thread safety issues (issue #630).
  * Add CefV8ContextHandler::OnUncaughtException callback (issue #736).
  * Add a new CefGetGeolocation function for retrieving geolocation information via an API callback (issue #764).
  * Windows: Enable IME for all text input types (issue #765).
  * Mac: Add default tooltip implementation (issue #770).
  * Add new CefDisplayHandler::OnFaviconURLChange callback (issue #779).
  * Add a switch to enable DCHECKs in release builds (issue #790).
  * Windows: Display select filters based on the "accept" attribute for input type="file" (issue #791).
  * Mac: Add default implementation for JavaScript confirm/prompt dialogs (issue #795).
  * Add new CefBrowser::GetIdentifier method (issue #811).
  * Mac: Fix crash with input element of type "file" when the default file name is empty (issue #823).
  * Allow empty |browser| parameter to CefSchemeHandlerFactory::Create (issue #834).
  * Windows: Add default implementation for JavaScript prompt dialog (issue #861).
  * Windows: cefclient: Remove dependency on ATL to allow building with Express versions of Visual Studio.

**February 9, 2013:** Version 3.1364.1094 contains the following enhancements and bug fixes.

  * Update to Chromium version 25.0.1364.68.
  * Mac: OS-X 10.5 (Leopard) is no longer supported.
  * Mac: Add support for Retina displays.
  * Default Google API keys for Geolocation are no longer supported. Register for custom API keys as described [here](http://www.chromium.org/developers/how-tos/api-keys).
  * Support custom V8 bindings on WebWorker threads (issue #451).
  * Add CefRenderProcessHandler callbacks for WebWorker context creation, release and uncaught exceptions (issue #451).
  * Add CefTaskRunner class that supports posting of tasks to standard threads and WebWorker threads (issue #451).
  * Support implicit detachment of CEF V8 references when the associated context is released (issue #484).
  * Reduce persistent CEF V8 memory usage by tracking objects on a per-context basis and not persisting objects when the underlying V8 handle is unused (issue #484).
  * cefclient: Add performance tests for CEF V8 methods (issue #484).
  * Windows: Add off-screen rendering support (issue #518).
  * Pass actual HTTP response code to CefLoadHandler::OnLoadEnd (issue #521).
  * Introduce chrome proxy implementation based on command-line flags (issue #600).
  * Expose tracing functionality via new cef\_trace.h and cef\_trace\_event.h headers (issue #711).
  * Add about:tracing UI support (issue #711).
  * Add new CefRenderProcessHandler::OnBeforeNavigation callback (issue #722).
  * Add about:version, about:credits and about:license internal URLs (issue #731).
  * Add CefV8ContextHandler::OnUncaughtException callback (issue #736).
  * Pass information to the renderer process synchronously on render thread creation and new browser creation to avoid race conditions (issue #744).
  * Add the ability to pass extra information to child processes using a new CefBrowserProcessHandler::OnRenderProcessThreadCreated callback (issue #744).
  * Pass resource-related command-line flags to all process types (issue #759).
  * Provide default implementations of the file chooser dialogs (open, open multiple, save) on all platforms (issue #761).
  * Add a new CefBrowserHost::RunFileDialog method that displays the specified file chooser dialog and returns the results asynchronously (issue #761).
  * Add a new CefDialogHandler::OnFileDialog callback that allows the application to provide custom UI for file chooser dialogs (issue #761).
  * Add a new CefGetGeolocation function for retrieving geolocation information via an API callback (issue #764).
  * Send OnTitleChange() notifications when navigating history (issue #766).
  * Add a CefSettings.release\_dcheck\_enabled option to enable DCHECKs in release builds (issue #790).
  * Do not send network requests for canceled popup windows (issue #816).
  * Fix assertion when returning NULL from CefClient::GetGeolocationHandler (issue #857).
  * Windows: Avoid assertion when entering zero-length text in the default JavaScript prompt dialog (issue #862).
  * Change CefBrowserSettings members that previously used a boolean to instead use a cef\_state\_t enumeration with default, enabled and disabled states (issue #878).
  * Remove CefBrowserSettings members that are unlikely to be used and that can also be set using Chromium command-line switches (issue #878).
  * Change the CEF command-line switch naming pattern to match Chromium and move the implementation out of cefclient (issue #878).

**October 2, 2012:** Version 1.1180.832 contains the following enhancements and bug fixes.

  * Update to Chromium version 21.0.1180.91. This fixes a number of bugs in Chromium and WebKit.
  * Add CefV8Value::CreateUInt method and indicate that integer types are 32bit via usage of int32 and uint32 types (issue #331).
  * Add geolocation support (issue #365).
  * Add CefV8Context::Eval method for synchronous JavaScript execution that returns a value or exception (issue #444).
  * Fix opening of password protected files with CefZipReader (issue #496).
  * Allow wmode="transparent" for Flash when using off-screen rendering (issue #527).
  * Remove support for HTML5 audio & video tags (issue #530).
  * Fix usage of ReadRawData return value in scheme handler implementation (issue #534).
  * Mac: Add off-screen rendering support (issue #540).
  * Add persistent HTML5 application cache support (issue #543).
  * Move exception handling from an ExecuteFunction argument to a CefV8Value attribute (issue #546).
  * Make user data an attribute for all CefV8Value object types and not just CreateObject (issue #547)
  * Rename PROXY\_TYPE values to avoid naming conflict (issue #548).
  * Mac: Add IME support (issue #557).
  * Change cefclient off-screen rendering example to account for premultiplied alpha values (issue #584).
  * Improve the cefclient transparency test by adding the ability to view individual pixel values (issue #584).
  * Windows: Fix mouse wheel scrolling in second monitor (issue #595).
  * Make the |target\_domain| parameter to CefAddCrossOriginWhitelistEntry and CefRemoveCrossOriginWhitelistEntry optional (issue #609).
  * Delay destroying the browser window until pending drag operations have completed (issue #610).
  * Fix misspelling of the Referer HTTP header (issue #619).
  * Mac: Add support for cef\_time\_t.day\_of\_week (issue #629).
  * Eliminate use of scoped directories (issue #670).
  * Only release the request context proxy if it exists (issue #677).
  * Add CefV8StackTrace and CefV8StackFrame interfaces to support retrieval of the JavaScript stack trace for the currently active V8 context (issue #682).
  * Fix crashes/assertions when CefBrowserImpl is destroyed on a non-UI thread (issue #694).
  * Improve the handling of invalidation/painting for off-screen rendering (issue #695).
  * Add the ability to customize the animation frame rate (issue #697).
  * Windows: Erase in-progress IME composition on cancel (issue #701).
  * Move devtools resources to a separate devtools\_resources.pak file to allow complete exclusion of devtools resources from client applications (issue #714).
  * Add a "url" command-line option to cefclient (issue #715).
  * Allow use of an empty key string with CefV8Value methods (issue #718).
  * Fix crash when pending navigation executes after the browser window has been destroyed (issue #724).
  * Mac: Add a CEF version number to dylib files (issue #730).
  * Add a CefZoomHandler interface to support custom zoom handling (issue #733).
  * Create a temporary cache\_path directory if none is specified (issue #735).
  * Windows: Fix VS2008 compile errors in CefByteReadHandler.

**September 28, 2012:** Version 3.1180.823 contains the following enhancements and bug fixes.

  * Update to Chromium version 21.0.1180.91. This fixes a number of bugs in Chromium and WebKit.
  * Fix opening of password protected files with CefZipReader (issue #496).
  * Rename PROXY\_TYPE values to avoid naming conflict (issue #548).
  * Add CefBrowserProcessHandler::OnBeforeChildProcessLaunch and CefCommandLine::PrependWrapper to support custom construction of the command line for child processes (issue #628).
  * Add CefRequestHandler::OnBeforePluginLoad callback and new cef\_web\_plugin.h functions for controlling plugin loading and life span (issue #645).
  * Implement CefDisplayHandler OnStatusMessage and OnConsoleMessage callbacks (issue #662).
  * Mac: Add libplugin\_carbon\_interpose.dylib to fix plugin crash (issue #680).
  * Add CefV8StackTrace and CefV8StackFrame interfaces to support retrieval of the JavaScript stack trace for the currently active V8 context (issue #682).
  * Fix a DCHECK failure when calling OnSetFocus from LoadRequest (issue #685).
  * Windows: Fix loading of custom cursor resources (issue #692).
  * Allow title change notifications after the document has loaded (issue #704).
  * Move devtools resources to a separate devtools\_resources.pak file to allow complete exclusion of devtools resources from client applications (issue #714).
  * Propagate logging command-line parameters to all processes (issue #717).
  * Allow use of an empty key string with CefV8Value methods (issue #718).
  * Mac: Add a CEF version number to dylib files (issue #730).
  * Add CefRequestHandler::OnQuotaRequest callback for handling webkitStorageInfo.requestQuota requests (issue #732).
  * Create a temporary cache\_path directory if none is specified (issue #735).
  * Windows: Fix VS2008 compile errors in CefByteReadHandler.

**June 28, 2012:** Version 3.1180.719 is the first binary release of CEF3. Below is an overview of features supported by this release. See the [CEF3 Development Status thread](http://magpcss.org/ceforum/viewtopic.php?f=10&t=645) for more information.

  * Windows, Mac OS-X and Linux support
  * Most HTML5 features
  * HTML5 drag&drop support (issue #504)
  * Geolocation support (issue #365)
  * GPU acceleration
  * Browser/frame load and navigation notifications
  * Resource request loading, interception and substitution
  * Custom scheme handling and cross-origin white lists
  * Custom proxy handling
  * Utility classes for command-line, URL, XML and zip reading/parsing
  * JavaScript binding & extension support (issue #506)
  * Direct cookie access (issue #512)
  * WebRTC support (issue #531)
  * User-defined cross-process communication (issue #544)
  * JavaScript dialog (alert, confirm, prompt, onbeforeunload) support (issue #507)
  * Context menu support (issue #509)
  * Direct DOM access (issue #511)
  * Keyboard and focus notifications/interception (issue #508)
  * Control over user data persistence (issue #510)
  * Zoom support (issue #514)
  * Download handling (issue #516)
  * External protocol handling (issue #582)
  * WebURLRequest support (issue #517)
  * Windows: multi\_threaded\_message\_loop run mode support (issue #522)

**April 26, 2012:** Version 1.1025.607 contains the following enhancements and bug fixes.

  * Break cef.h into multiple headers (issue #142).
  * Add the ability to disable or customize pack file load paths (issue #236).
  * Allow custom resource bundle handling via CefResourceBundleHandler (issue #236).
  * Remove the CefV8Value::CreateObject variant that accepts only one argument (issue #449).
  * Invalidate the entire scroll rect when using off-screen rendering mode (issue #469)
  * Add the ability to restrict V8 extension loading by frame using a new CefPermissionHandler::OnBeforeScriptExtensionLoad() callback (issue #471).
  * Make CEF compliant with Google/Chromium style (issue #473).
  * Add methods to CefV8Value for specifying the amount of externally allocated memory associated with the V8 object (issue #478).
  * Don't add the "--expose-gc" V8 flag by default for all CEF users (issue #483).
  * Fix bug in CefZipArchive::Clear() (issue #486).
  * Mac: Fix the "no autorelease pool in place" error by initializing an NSAutoreleasePool on every thread (issue #502).
  * Fix memory leak in CefV8ValueImpl::ExecuteFunctionWithContext (issue #526).
  * Fix the OnBeforeResourceLoad redirectUrl value to behave the same as using request->SetURL() (issue #529).
  * Windows: Fix crash in cefclient when entering long URLs via the address bar (issue #532).
  * Add CefCookieManager interface and CefRequestHandler::GetCookieManager for custom cookie handling (issue #542).
  * Support getting and setting cookies with custom scheme handlers (issue #555).
  * Support calling CefFrame::GetIdentifier and CefFrame::GetURL on any thread (issue #556).
  * Add CefCookieManager::SetSupportedSchemes method which supports cookie storage for non-http(s) schemes (issue #567).
  * Mac: Add flagsChanged: signal handler so that modifier keys are correctly passed to JS (issue #574).
  * Add the ability to directly retrieve plugin information via CefGetWebPluginInfo (issue #575).
  * Fix memory leak when returning zero-length strings from V8 (issue #581).

**December 22, 2011:** Version 1.963.439 contains the following enhancements and bug fixes.

  * Fix crash on shutdown due to CefProcess not being destroyed immediately (issue #277).
  * Introduce CefV8Exception for returning detailed exception information from CefV8Value::ExecuteFunction() and add the ability to re-throw exceptions (issue #317).
  * Include CEF and Chromium version information in binary distributions (issue #325).
  * Disable stats, histogram and event tracing to avoid memory leaks (issue #328).
  * Add the ability to observe and modify resource redirects (issue #346).
  * Replace JSBindingHandler with a new V8ContextHandler interface that contains callbacks for V8 context creation and release (issue #359).
  * Significant improvements in painting and scrolling performance (issue #360).
  * (win) Fix CefBrowser::GetImage() and add "Get Image" example to cefclient (issue #377).
  * Add a new CefProxyHandler interface to allow applications to resolve proxy information (issue #389).
  * Add a new CefApp interface that provides global handlers and gets passed to CefInitialize() (issue #399).
  * Pass a list of dirty rectangles instead of a single combined rectangle to CefRenderHandler::Paint() (issue #415).
  * (win) Use the module path for loading resources instead of hard-coding "libcef.dll" (issue #416).
  * Add a CefBrowserSettings.history\_disabled option to disable history back/forward navigation (issue #419).
  * Expose command line parsing support with a new CefCommandLine class (issue #422).
  * (win) Fix selection of multiple files with long combined paths (issue #423).
  * (mac) Fix handling of numeric pad characters. Don't send character events for non-character numeric and function keys (issue #426).
  * Add a CefV8Context::InContext() method to test if V8 is currently in a context (issue #427).
  * Verify that a current context exists when creating V8 arrays, functions and objects (issue #427).
  * Add a v8::HandleScope in GetCurrentContext() and GetEnteredContext() to avoid "Cannot create a handle without a HandleScope" V8 errors (issue #427).
  * Add additional error checking for CefV8Value methods (issue #427).
  * Make navigator.language return the same value as CefSettings.locale (issue #429).
  * Verify that libcef build revision and API/header revision match when initializing CEF (issue #431).
  * Allow registration of V8 extensions with no native function handler (issue #433).
  * Fix crash caused by V8Proxy::retrieveFrameForCallingContext() returning 0 in V8DOMWindowCustom::handlePostMessageCallback (issue #436).
  * Fix BrowserFileSystem context creation race condition between UI and IO threads (issue #442).
  * Add CefQuitMessageLoop function (issue #443).
  * Allow media hosting from all schemes (issue #446).
  * (mac) Fix problem where images loaded using the background-image CSS attribute sometimes do not display after browsing back to the page (issue #447).
  * Expose unique identifiers for frames and the ability to retrieve a frame's parent frame (issue #450).
  * Reduce CPU usage with requestAnimationFrame by maintaining a consistent 60fps frame rate (issue #456).
  * (win) Reduce memory/CPU usage with UpdateInputMethod by restricting tasks to every 100ms (issue #454).
  * Add CefBrowserSettings.fullscreen\_enabled flag for enabling fullscreen mode (issue #457).


**November 8, 2011:** Binary release 365 contains the following enhancements and bug fixes.

  * (win) Add support for transparency (issue #99).
  * (win) Fix the transparent background for the toolbar in DevTools (issue #313).
  * Hide CEF internal V8 attributes from JavaScript (issue #316).
  * Fix problem calling CefBrowser::SetFocus() from a non-UI thread (issue #320).
  * (win) Add CefSettings.auto\_detect\_proxy\_settings\_enabled option for enabling automatic proxy detection (issue #332).
  * Add CefDisplayHandler::OnContentsSizeChange() notificiation (issue #341).
  * Add handling for empty V8 exception messages (issue #342).
  * Add CefFrame::GetV8Context() method for retrieving the V8 context of a frame (issue #344).
  * Add CefSetCookiePath() and CefSetStoragePath() functions for changing cookie and localStorage locations while CEF is running (issue #347).
  * (mac) Significant repaint and scroll performance improvements (issue #360).
  * Add a new NAVTYPE\_LINKDROPPED value that will be passed to OnBeforeResourceLoad() when navigation is resulting from drag & drop of URLs (issue #363).
  * Add a CefBrowserSettings.load\_drops\_disabled option for disabling default navigation resulting from drag & drop of URLs (issue #363).
  * (win) Look for the chrome.pak file in the module (libcef.dll) directory to match the locale folder location (issue #374).
  * Add CefFocusHandler::OnFocusedNodeChanged() notification (issue #379).
  * Add CefDOMNode::IsFormControlElement() and CefDOMNode::GetFormControlElementType() methods (issue #379).
  * Don't call OnTitleChange() and OnLoadEnd() for failed provisional loading (issue #381).
  * Use cef-error URLs for error pages (issue #382).
  * Use multimap type for storing header values (issue #386).
  * Re-register the internal chrome-devtools scheme handler after CefClearSchemeHandlerFactories() is called (issue #398).
  * Add the ability to specify full plugin matching parameters including multiple mime types and file extensions via CefPluginInfo (issue #401).
  * (mac) Add file chooser support for input type="file" (issue #403).
  * Add new call to OnKeyEvent() to allow handling of keyboard events before they're passed to the renderer (issue #406).
  * (win) Only scroll with the middle mouse button when the cursor is over the view (issue #410).
  * Add a PropertyAttribute parameter to CefV8Value::SetValue() (issue #412).
  * Add support for specifying custom V8 flags via a new CefSettings.javascript\_flags configuration option (issue #413).
  * Pass the |redirectUrl| parameter to GetResponseHeaders() instead of ProcessRequest() (issue #414).

**October 7, 2011:** Binary release 306 introduces the new distribution packaging system (issue #260) that provides binary distributions for both Windows and Mac OS X. It also contains the following enhancements and bug fixes.

  * (mac) Don't show magenta background when redrawing in release build (issue #300).
  * Increase the internal resource buffer size to the maximum allowed to improve resource loading speed (issue #301).
  * Add CefSettings.local\_storage\_quota and CefSettings.session\_storage\_quota options for setting localStorage and sessionStorage quota limits respectively (issue #348).
  * Add a CefBrowser::ClearHistory() method for clearing back/forward browsing history (issue #352).
  * Add support for loading localized strings from locale .pak files (issue #357).
  * Add support for loading DevTools resources from chrome.pak via the chrome-devtools scheme (issue #358).
  * Improve redraw and scrolling performance (issue #360).
  * Add storage functions and CefStorageVisitor interface for accessing localStorage and sessionStorage data via the native API (issue #361).
  * Pass the browser originating the request to CefSchemeHandlerFactory::Create() (issue #362).
  * Add a FocusSource parameter to OnSetFocus() that indicates where the focus request is originating from (issue #369).

**September 23, 2011:** Binary release 293 adds support for Visual Studio 2010 and contains the following enhancements and bug fixes.

  * Rename char16\_t to char16 to fix VS2010 compiler errors due to char16\_t becoming a built-in type (issue #243).
  * Support asynchronous continuation of custom scheme handler responses (issue #269).
  * Add CefDragHandler to support examination of drag data and cancellation of drag requests (issue #297).
  * Add a CefBrowser::HasDocument() method that tests if a document has been loaded in the browser window (issue #307).
  * Add a virtual destructor to the CefBase class (issue #321).
  * Fix memory leaks in V8 usage (issue #323).
  * Improve performance of V8 string conversions (issue #323).
  * Add the ability to return exceptions from V8 accessors (issue #327).
  * Return undefined instead of null from a V8 handler if no return value is specified (issue #329).
  * Accelerated compositing has been disabled by default due to implementation bugs (issue #334, issue #335, issue #337).

**August 9, 2011:** Binary release 275 contains the following enhancements and bug fixes.

  * Disable touch support to allow Google Maps API to function correctly (issue #134).
  * Fix a deadlock when executing many synchronous load requests (issue #192).
  * Fix OnResourceResponse spelling error (issue #270).
  * Fix a thread death race condition that can result in a crash in some circumstances on shutdown (issue #277).
  * Add support for accelerated\_video\_enabled, accelerated\_drawing\_enabled and accelerated\_plugins\_enabled browser settings (issue #278).
  * Add d3dx9\_43.dll and d3dcompiler\_43.dll files required by accelerated content on some Windows machines (issue #280).
  * Clean up the implementation of modal window callbacks (issue #281).
  * Disable speech input to avoid a crash when clicking the microphone icon on the Google search page (issue #282).
  * Add support for disabling HTML5 drag from the browser by setting drag\_drop\_disabled to true (issue #284).
  * Fix a crash when canceling a popup window (issue #285).

**June 14, 2011:** Binary release 259 significantly revamps the CEF API and contains the following enhancements and bug fixes.

  * Use the angle library for GL support (issue #136).
  * Add Date type support to CefV8Value (issue #190).
  * Add a workaround for the SyncRequestProxy deadlock problem (issue #192).
  * Replace CefHandler with a new CefClient interface and separate handler interfaces (issue #218).
  * Add support for virtual inheritance to allow multiple CefBase parented interfaces to be implemented in the same class (issue #218).
  * Replace CefThreadSafeBase with IMPLEMENT macros to support virtual inheritance and to only provide locking implementations when needed (issue #218).
  * Move the CefBrowserSettings parameter from CefInitialize to CreateBrowser (issue #218).
  * Add a new cef\_build.h header that provides platform-specific and OS defines (issue #218).
  * Introduce the use of OVERRIDE to generate compiler errors on Windows if a child virtual method declaration doesn't match the parent declaration (issue #218).
  * Move CEF header files that should not be directly included by the client to the "include/internal" folder (issue #218).
  * Add support for navigator.onLine and online/offline window events (issue #234).
  * Use NDEBUG instead of `_`DEBUG because `_`DEBUG is not defined on Mac (issue #240).
  * Add OnResourceReponse and CefContentFilter for viewing and filtering response content (issue #241).
  * Add support for setting response header values (issue #246).
  * Break CefRegisterScheme into separate CefRegisterCustomScheme and CefRegisterSchemeHandlerFactory functions (issue #246).
  * Allow registration of handlers for built-in schemes (issue #246).
  * Supply scheme and request information to CefSchemeHandlerFactory::Create (issue #246).
  * Add CrossOriginWhitelist functions for bypassing the same-origin policy with both built-in and custom standard schemes (issue #246).
  * Add support for modal dialogs (issue #250).
  * Add support for IME-aware applications (issue #254).
  * Restore keyboard focus on window activation (issue #256).
  * Fix bug when dragging to a window before mouse events have been detected (issue #262).

**May 10, 2011:** Binary release 231 contains the following enhancements and bug fixes.

  * Add cookie get/set support (issue #88).
  * Allow custom schemes to cause redirects (issue #98).
  * Set the libcef.dll version number to the build revision number (issue #108).
  * Add support for returning an HTTP status code from HandleBeforeResourceLoad and custom scheme handlers via the CefResponse class (issue #202).
  * Add support for V8 accessors and entering a V8 context asynchronously (issue #203).
  * Don't load URLs twice for popup windows (issue #215).
  * Make modal popup windows behave the same as non-modal popup windows (issue #216).
  * Force Flash and Silverlight plugins to use windowless mode when rendering off-screen (issue #214).
  * Don't download files that will be loaded by a plugin (issue #227).
  * Add a CefDOMNode::IsSame() method for comparing CefDOMNode objects.

**March 25, 2011:** Binary release 212 contains the following enhancements and bug fixes.

  * Add off-screen rendering support (issue #100).
  * Add persistent storage support for cookie data (issue #193).
  * Allow registration of non-standard schemes (issue #195).
  * Improve the behavior of HandleAddressChange, HandleTitleChange, HandleLoadStart and HandleLoadEnd notifications (issue #200).
  * Respect the WS\_VISIBLE flag when creating browser windows (issue #201).
  * Fix a bug in CefWebURLRequest that could result in inappropriate calls to CefHandler methods (issue #204).
  * Add a history entry when navigating to anchors within the same page (issue #207).
  * Add a HandleNavStateChange notification for back/forward state changes (issue #208).
  * Fix crash when using WebKit inspector break points (issue #210).
  * Add support for retrieving values from DOM form elements using CefDOMNode::GetValue.
  * Add the CefRunMessageLoop() function for efficient message loop processing in single-threaded message loop mode.

**February 28, 2011:** Binary release 195 contains the following enhancements and bug fixes.

  * Add the CefWebURLRequest class that supports direct loading of URL resources from client applications (issue #51).
  * Add CefDOM classes and the CefFrame::VisitDOM method that allow direct access to and modification of the DOM (issue #60).
  * Add support for the HTML5 drag and drop API and support for dragging content to other applications or the desktop (issue #140).
  * Add a CefV8Context object and CefV8Value::ExecuteFunctionWithContext method to support asynchronous V8 callbacks (issue #188).
  * CefRegisterPlugin now only supports a single mime type per registration.
  * Fix a bug where URL and title change notifications were not being sent for CefFrame::LoadString.

**February 1, 2011:** Binary release 181 will be the last binary release that includes libraries for VS2005. It contains the following enhancements and bug fixes.

  * Improve thread safety by making some methods only callable on the UI thread (issue #175).
  * Add NewCefRunnableMethod and NewCefRunnableFunction templates (in cef\_runnable.h) that simplify task posting (issue #175).
  * Add a boolean argument to the HandleLoadStart and HandleLoadEnd events that will be true while the main content frame is loading (issue #166, issue #183).
  * Add an HTTP status code argument to the HandleLoadEnd event (issue #177).
  * Only call the HandleAddressChange and HandleTitleChange events for the main content frame load (issue #166)
  * Pass the URL for new popup windows to the HandleBeforeCreated event (issue #5).
  * Add members to the CefSettings structure for specifying log file location and severity level (issue #172).
  * Add single sign-on support (issue #148).
  * Add zooming support (issue #116).
  * Add developer tools support (issue #127).
  * Add a HandleProtocolExecution event for handling unregistered protocols (issue #155).
  * Add a HandleStatus event for status messages, mouse over URLs and keyboard focus URLs (issue #61).
  * Add support for creating and parsing URLs via CefCreateURL and CefParseURL (issue #181).
  * Fix the problem with frame activation when displaying SELECT list popups (issue #169).
  * Accelerated compositing and HTML5 video now work together (issue #143).

**November 22, 2010:** Revision 149 introduces a number of long-awaited features and a few important bug fixes.

  * The API now uses CefString and cef\_string\_t types instead of std::wstring and wchar\_t. The new types support conversion between ASCII, UTF-8, UTF-16 and UTF-32 character formats and the default character type can be changed by recompiling CEF (issue #146).
  * Allow customization of global and per-browser settings for everything from User-Agent and plugin search paths to specific WebKit features (issue #145).
  * Add support for accelerated compositing and fast WebGL (issue #136). You will need to disable accelerated compositing to watch HTML5 video with this release (issue #143).
  * Expose popup window feature information via the CefPopupFeatures argument passed to CefHandler::HandleBeforeCreated (issue #135).
  * Fix a crash caused by Flash-related JavaScript (issue #115).

**November 15, 2010:** Revision 137 provides the first working build of CEF for the Mac OS X platform (issue #68). There's still a lot of work required to bring it up to par with the Windows port. Missing features are indicated by "TODO(port)" comments in the source code. Help with fixing bugs and implementing missing features is welcome.

**October 24, 2010:** Revision 126 disables WebGL support due to performance problems with the default Chromium implementation. WebGL support will be re-enabled once a better-performing implementation is available (issue #136).

  * Add a CefHandler::HandleDownloadResponse() method for handling Content-Disposition initiated file downloads (issue #6).
  * Add XML parsing support with CefXmlReader and CefXmlObject classes (issue #28).
  * Add Zip archive reading support with CefZipReader and CefZipArchive classes (issue #30).
  * Add a new cef\_wrapper.h header file that exposes helpful utility classes provided as part of the libcef\_dll\_wrapper target.

**October 15, 2010:** Revision 116 causes CEF to ignore the "Automatically detect settings" option under LAN Settings in order to fix a problem with slow resource loading on Windows (issue #81). Manual configuration under LAN Settings is still respected.

  * Add a CefBrowser::ReloadIgnoreCache() method and MENU\_ID\_NAV\_RELOAD\_NOCACHE menu support. (issue #118).
  * Add support for audio playback with HTML5 video (issue #121).
  * Fix back/forward navigation when the history contains pages that failed to load (issue #125).
  * Change the CEF User-Agent product version to "Chrome/7.0.517.0"

**August 31, 2010:** Revision 100 re-introduces the CefHandler::HandleJSBinding method.  The memory leaks that necessitated the elimination of this method have now been fixed (issue #72).

  * The CefRequest argument to CefHandler::HandleBeforeResourceLoad can now be modified allowing the request to be changed on the fly (issue #41).
  * A default tooltip implementation is now provided and tooltip text can be modified using CefHandler::HandleTooltip (issue #61).
  * Printing paper size, orientation and margins can now be changed using CefHandler::HandlePrintOptions (issue #112).
  * Find in page with result highlighting is now supported using CefBrowser::Find, CefBrowser::StopFinding and CefHandler::HandleFindResult.
  * The binary release of revision 100 provides libraries for both Visual Studio 2005 and Visual Studio 2008. It can be downloaded from the project Downloads page.

**April 7, 2010:** Revision 73 eliminates the CefHandler::HandleJSBinding method.  This modification addresses memory leaks that many users have been reporting.  For more information see issue #72.

**October 2, 2009:** Revision 50 adds [GYP support](http://code.google.com/p/gyp/) for generating the CEF project files. This makes it easy to build CEF with both VS2005 and VS2008. See the "Source Distributions" section above for additional details.

**August 21, 2009:** Revision 37 adds support for custom scheme handlers. Use the new CefRegisterScheme() function in combination with the CefSchemeHandlerFactory and CefSchemeHandler classes to create handlers for requests using custom schemes such as myscheme://mydomain.

**July 24, 2009:** Revision 32 helps to speed up the addition of new features and bug fixes to CEF. It adds the CEF Patch Application Tool and the "patch" project which together support automatic application of patches to the Chromium and WebKit source trees as part of the build process. See the README.txt file in the new patch directory for additional information.

**July 8, 2009:** CEF now has a dedicated build bot thanks to Nicolas Sylvain and Darin Fisher over at Google. The build bot synchronizes to each Chromium revision and then builds CEF, reporting on any compile errors that occur. Having a build bot for CEF will help the Chromium developers avoid accidentally breaking API features required by CEF, and help the CEF developers keep up with the frequently changing Chromium HEAD revision. You can view the build bot output at http://build.chromium.org/buildbot/waterfall.fyi/waterfall?branch=&builder=Chromium+Embedded

**June 20, 2009:** Revision 30 adds the CEF Translator Tool which facilitates automatic generation of the C API header file (cef\_capi.h) and CToCpp/CppToC wrapper classes. See the translator.README.txt file in the new tools directory for additional information.  Introduction of this tool required minor changes to the CEF C++ and C APIs.

  * The C++ 'arguments' attribute of CefV8Handler::Execute() and CefV8Value::ExecuteFunction() now has the 'const' qualifier.
  * C API global function names that were previously in the cef\_create\_classname() format are now in the cef\_classname\_create() format.
  * The C API cef\_frame\_t::get\_frame\_names() member function now has return type 'void' instead of 'size\_t'.
  * The C API cef\_frame\_t::execute\_javascript() member function has been renamed to cef\_frame\_t::execute\_java\_script().

**May 27, 2009:** Revision 26 introduces two major changes to the CEF framework.

  * Frame-dependent functions such as loading content and executing JavaScript have been moved to a new CefFrame class.  Use the new CefBrowser::Get\*Frame() methods to retrieve the appropriate CefFrame instance.  A CefFrame instance will now also be passed to CefHandler callback methods as appropriate.
  * The CEF JavaScript API now uses the V8 framework directly instead of creating NPObjects.  JavaScript object hierarchies can be written in native C++ code and exported to the JavaScript user-space, and user-space object hierarchies can be accessed from native C++ code. Furthermore, support for the V8 extension framework has been added via the new CefRegisterExtension() function. The CefJSHandler and CefVariant classes have been removed in favor of new CefV8Handler and CefV8Value classes. To attach values to the JavaScript 'window' object you must now implement the CefHandler::HandleJSBinding() callback method instead of calling the (now removed) CefBrowser::AddJSHandler() method.