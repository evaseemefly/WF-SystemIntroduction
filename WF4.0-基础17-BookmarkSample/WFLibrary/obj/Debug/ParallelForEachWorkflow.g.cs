//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.21006.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace WFLibrary {
    
    
    [System.Runtime.InteropServices.ComVisible(false)]
    public partial class ParallelForEachWorkflow : System.Activities.Activity, System.ComponentModel.ISupportInitialize {
        
        private bool _contentLoaded;
        
        private System.Activities.InArgument<System.Collections.Generic.SortedSet<string>> _myNameList;
        
        public ParallelForEachWorkflow() {
            this.InitializeComponent();
        }
        
        public System.Activities.InArgument<System.Collections.Generic.SortedSet<string>> myNameList {
            get {
                return this._myNameList;
            }
            set {
                this._myNameList = value;
            }
        }
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if ((this._contentLoaded == true)) {
                return;
            }
            this._contentLoaded = true;
            string resourceName = this.FindResource();
            System.IO.Stream initializeXaml = typeof(ParallelForEachWorkflow).Assembly.GetManifestResourceStream(resourceName);
            System.Xml.XmlReader xmlReader = null;
            System.Xaml.XamlReader reader = null;
            System.Xaml.XamlObjectWriter objectWriter = null;
            try {
                System.Xaml.XamlSchemaContext schemaContext = _XamlStaticHelperNamespace._XamlStaticHelper.SchemaContext;
                xmlReader = System.Xml.XmlReader.Create(initializeXaml);
                System.Xaml.XamlXmlReaderSettings readerSettings = new System.Xaml.XamlXmlReaderSettings();
                readerSettings.LocalAssembly = System.Reflection.Assembly.GetExecutingAssembly();
                readerSettings.AllowProtectedMembersOnRoot = true;
                reader = new System.Xaml.XamlXmlReader(xmlReader, schemaContext, readerSettings);
                System.Xaml.XamlObjectWriterSettings writerSettings = new System.Xaml.XamlObjectWriterSettings();
                writerSettings.RootObjectInstance = this;
                writerSettings.AccessLevel = System.Xaml.Permissions.XamlAccessLevel.PrivateAccessTo(typeof(ParallelForEachWorkflow));
                objectWriter = new System.Xaml.XamlObjectWriter(schemaContext, writerSettings);
                System.Xaml.XamlServices.Transform(reader, objectWriter);
            }
            finally {
                if ((xmlReader != null)) {
                    ((System.IDisposable)(xmlReader)).Dispose();
                }
                if ((reader != null)) {
                    ((System.IDisposable)(reader)).Dispose();
                }
                if ((objectWriter != null)) {
                    ((System.IDisposable)(objectWriter)).Dispose();
                }
            }
        }
        
        private string FindResource() {
            string[] resources = typeof(ParallelForEachWorkflow).Assembly.GetManifestResourceNames();
            for (int i = 0; (i < resources.Length); i = (i + 1)) {
                string resource = resources[i];
                if ((resource.Contains(".ParallelForEachWorkflow.g.xaml") || resource.Equals("ParallelForEachWorkflow.g.xaml"))) {
                    return resource;
                }
            }
            throw new System.InvalidOperationException("Resource not found.");
        }
        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033")]
        void System.ComponentModel.ISupportInitialize.BeginInit() {
        }
        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033")]
        void System.ComponentModel.ISupportInitialize.EndInit() {
            this.InitializeComponent();
        }
    }
}
