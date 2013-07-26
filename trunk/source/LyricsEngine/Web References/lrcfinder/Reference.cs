﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18047
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.18047.
// 
#pragma warning disable 1591

namespace LyricsEngine.lrcfinder {
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="LrcFinderSoap", Namespace="http://tempuri.org/")]
    public partial class LrcFinder : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback FindLRCOperationCompleted;
        
        private System.Threading.SendOrPostCallback FindLRCsOperationCompleted;
        
        private System.Threading.SendOrPostCallback SaveLRCOperationCompleted;
        
        private System.Threading.SendOrPostCallback SaveLRCWithGuidOperationCompleted;
        
        private System.Threading.SendOrPostCallback NewDomainOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public LrcFinder() {
            this.Url = global::LyricsEngine.Properties.Settings.Default.LyricsEngine_lrcfinder_LrcFinder;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event FindLRCCompletedEventHandler FindLRCCompleted;
        
        /// <remarks/>
        public event FindLRCsCompletedEventHandler FindLRCsCompleted;
        
        /// <remarks/>
        public event SaveLRCCompletedEventHandler SaveLRCCompleted;
        
        /// <remarks/>
        public event SaveLRCWithGuidCompletedEventHandler SaveLRCWithGuidCompleted;
        
        /// <remarks/>
        public event NewDomainCompletedEventHandler NewDomainCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/FindLRC", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string FindLRC(string artist, string title) {
            object[] results = this.Invoke("FindLRC", new object[] {
                        artist,
                        title});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void FindLRCAsync(string artist, string title) {
            this.FindLRCAsync(artist, title, null);
        }
        
        /// <remarks/>
        public void FindLRCAsync(string artist, string title, object userState) {
            if ((this.FindLRCOperationCompleted == null)) {
                this.FindLRCOperationCompleted = new System.Threading.SendOrPostCallback(this.OnFindLRCOperationCompleted);
            }
            this.InvokeAsync("FindLRC", new object[] {
                        artist,
                        title}, this.FindLRCOperationCompleted, userState);
        }
        
        private void OnFindLRCOperationCompleted(object arg) {
            if ((this.FindLRCCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.FindLRCCompleted(this, new FindLRCCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/FindLRCs", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable FindLRCs(string artist, string title) {
            object[] results = this.Invoke("FindLRCs", new object[] {
                        artist,
                        title});
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void FindLRCsAsync(string artist, string title) {
            this.FindLRCsAsync(artist, title, null);
        }
        
        /// <remarks/>
        public void FindLRCsAsync(string artist, string title, object userState) {
            if ((this.FindLRCsOperationCompleted == null)) {
                this.FindLRCsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnFindLRCsOperationCompleted);
            }
            this.InvokeAsync("FindLRCs", new object[] {
                        artist,
                        title}, this.FindLRCsOperationCompleted, userState);
        }
        
        private void OnFindLRCsOperationCompleted(object arg) {
            if ((this.FindLRCsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.FindLRCsCompleted(this, new FindLRCsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SaveLRC", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string SaveLRC(string lrcFileString) {
            object[] results = this.Invoke("SaveLRC", new object[] {
                        lrcFileString});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void SaveLRCAsync(string lrcFileString) {
            this.SaveLRCAsync(lrcFileString, null);
        }
        
        /// <remarks/>
        public void SaveLRCAsync(string lrcFileString, object userState) {
            if ((this.SaveLRCOperationCompleted == null)) {
                this.SaveLRCOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSaveLRCOperationCompleted);
            }
            this.InvokeAsync("SaveLRC", new object[] {
                        lrcFileString}, this.SaveLRCOperationCompleted, userState);
        }
        
        private void OnSaveLRCOperationCompleted(object arg) {
            if ((this.SaveLRCCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SaveLRCCompleted(this, new SaveLRCCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SaveLRCWithGuid", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string SaveLRCWithGuid(string lrcFileString, System.Guid guid) {
            object[] results = this.Invoke("SaveLRCWithGuid", new object[] {
                        lrcFileString,
                        guid});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void SaveLRCWithGuidAsync(string lrcFileString, System.Guid guid) {
            this.SaveLRCWithGuidAsync(lrcFileString, guid, null);
        }
        
        /// <remarks/>
        public void SaveLRCWithGuidAsync(string lrcFileString, System.Guid guid, object userState) {
            if ((this.SaveLRCWithGuidOperationCompleted == null)) {
                this.SaveLRCWithGuidOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSaveLRCWithGuidOperationCompleted);
            }
            this.InvokeAsync("SaveLRCWithGuid", new object[] {
                        lrcFileString,
                        guid}, this.SaveLRCWithGuidOperationCompleted, userState);
        }
        
        private void OnSaveLRCWithGuidOperationCompleted(object arg) {
            if ((this.SaveLRCWithGuidCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SaveLRCWithGuidCompleted(this, new SaveLRCWithGuidCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/NewDomain", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] NewDomain() {
            object[] results = this.Invoke("NewDomain", new object[0]);
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public void NewDomainAsync() {
            this.NewDomainAsync(null);
        }
        
        /// <remarks/>
        public void NewDomainAsync(object userState) {
            if ((this.NewDomainOperationCompleted == null)) {
                this.NewDomainOperationCompleted = new System.Threading.SendOrPostCallback(this.OnNewDomainOperationCompleted);
            }
            this.InvokeAsync("NewDomain", new object[0], this.NewDomainOperationCompleted, userState);
        }
        
        private void OnNewDomainOperationCompleted(object arg) {
            if ((this.NewDomainCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.NewDomainCompleted(this, new NewDomainCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void FindLRCCompletedEventHandler(object sender, FindLRCCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FindLRCCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal FindLRCCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void FindLRCsCompletedEventHandler(object sender, FindLRCsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FindLRCsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal FindLRCsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataTable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataTable)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void SaveLRCCompletedEventHandler(object sender, SaveLRCCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SaveLRCCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SaveLRCCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void SaveLRCWithGuidCompletedEventHandler(object sender, SaveLRCWithGuidCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SaveLRCWithGuidCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SaveLRCWithGuidCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void NewDomainCompletedEventHandler(object sender, NewDomainCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class NewDomainCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal NewDomainCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591