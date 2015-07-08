// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 12.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.NuGet
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\dev\Xamarin\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class Nuspec : NuspecBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<package> \r\n  <metadata> \r\n    <id>");
            
            #line 9 "C:\dev\Xamarin\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["AssemblyName"]));
            
            #line default
            #line hidden
            this.Write("</id>\r\n    <title>");
            
            #line 10 "C:\dev\Xamarin\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["AssemblyTitle"]));
            
            #line default
            #line hidden
            this.Write("</title>\r\n    <version>");
            
            #line 11 "C:\dev\Xamarin\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["AssemblyVersion"]));
            
            #line default
            #line hidden
            this.Write("-preview</version> \r\n    <authors>Amazon Web Services</authors>\r\n    <description" +
                    ">");
            
            #line 13 "C:\dev\Xamarin\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["AssemblyDescription"]));
            
            #line default
            #line hidden
            this.Write("</description> \r\n    <language>en-US</language>\r\n    <licenseUrl>http://aws.amazo" +
                    "n.com/apache2.0/</licenseUrl>    \r\n    <projectUrl>https://github.com/aws/aws-sd" +
                    "k-net/tree/modularization/</projectUrl>\r\n    <tags>AWS Amazon cloud ");
            
            #line 17 "C:\dev\Xamarin\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["BaseName"]));
            
            #line default
            #line hidden
            this.Write(@"</tags>
    <iconUrl>http://media.amazonwebservices.com/aws_singlebox_01.png</iconUrl>
    <dependencies>
      <group targetFramework=""portable-net45+netcore45+wpa81+wp8+MonoAndroid10+xamarinios10+MonoTouch10"">
        <dependency id=""Microsoft.Net.Http"" version=""2.2.29"" />
        <dependency id=""PCLStorage"" version=""1.0.2"" />
        <dependency id=""PCLCrypto"" version=""1.0.2.15130"" />
");
            
            #line 24 "C:\dev\Xamarin\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"

    foreach(var awsDependencyKVP in ((IDictionary<string, string>)this.Session["AWSDependencies"]))
    {

            
            #line default
            #line hidden
            this.Write("      <dependency id=\"");
            
            #line 28 "C:\dev\Xamarin\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(awsDependencyKVP.Key));
            
            #line default
            #line hidden
            this.Write("\" version=\"");
            
            #line 28 "C:\dev\Xamarin\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(awsDependencyKVP.Value));
            
            #line default
            #line hidden
            this.Write("\" />\r\n");
            
            #line 29 "C:\dev\Xamarin\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"

    }

            
            #line default
            #line hidden
            
            #line 32 "C:\dev\Xamarin\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"

	if(this.Session.ContainsKey("NugetDependencies"))
    {
		var dependencies = (Dictionary<string,List<Dependency>>)this.Session["NugetDependencies"];
		if(dependencies.ContainsKey("PCL"))
		{
			foreach(var dependency in dependencies["PCL"])
			{

            
            #line default
            #line hidden
            this.Write("\t\t<dependency id=\"");
            
            #line 41 "C:\dev\Xamarin\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dependency.Name));
            
            #line default
            #line hidden
            this.Write("\" version=\"");
            
            #line 41 "C:\dev\Xamarin\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dependency.Version));
            
            #line default
            #line hidden
            this.Write("\" />\r\n");
            
            #line 42 "C:\dev\Xamarin\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
		
			}
		}
	}	

            
            #line default
            #line hidden
            this.Write("      </group>\r\n");
            
            #line 48 "C:\dev\Xamarin\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"

	if(this.Session.ContainsKey("NugetDependencies"))
    {
		var dependencies = (Dictionary<string,List<Dependency>>)this.Session["NugetDependencies"];
		foreach(var dependencyList in dependencies)
		{
			if(dependencyList.Key.Equals("PCL"))
				continue;

			var projectFileConfigurations = (IEnumerable<ProjectFileConfiguration>)this.Session["ProjectFileConfigurations"];
			var targetFramework = projectFileConfigurations.Single(p=>p.Name.Equals(dependencyList.Key)).NuGetTargetPlatform;

            
            #line default
            #line hidden
            this.Write("\t\t\t\r\n      <group targetFramework=\"");
            
            #line 60 "C:\dev\Xamarin\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(targetFramework));
            
            #line default
            #line hidden
            this.Write("\">\r\n");
            
            #line 61 "C:\dev\Xamarin\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"

				foreach(var dependency in dependencyList.Value)
				{
	
            
            #line default
            #line hidden
            this.Write("\t\t\t<dependency id=\"");
            
            #line 65 "C:\dev\Xamarin\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dependency.Name));
            
            #line default
            #line hidden
            this.Write("\" version=\"");
            
            #line 65 "C:\dev\Xamarin\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dependency.Version));
            
            #line default
            #line hidden
            this.Write("\" />\r\n\t");
            
            #line 66 "C:\dev\Xamarin\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
		
				}

            
            #line default
            #line hidden
            this.Write("      </group>\r\n");
            
            #line 70 "C:\dev\Xamarin\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"

		}
	}	

            
            #line default
            #line hidden
            this.Write("      <group>\r\n");
            
            #line 75 "C:\dev\Xamarin\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"

    foreach(var awsDependencyKVP in ((IDictionary<string, string>)this.Session["AWSDependencies"]))
    {

            
            #line default
            #line hidden
            this.Write("\t\t<dependency id=\"");
            
            #line 79 "C:\dev\Xamarin\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(awsDependencyKVP.Key));
            
            #line default
            #line hidden
            this.Write("\" version=\"");
            
            #line 79 "C:\dev\Xamarin\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(awsDependencyKVP.Value));
            
            #line default
            #line hidden
            this.Write("\" />\r\n");
            
            #line 80 "C:\dev\Xamarin\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"

    }

            
            #line default
            #line hidden
            this.Write("      </group>\r\n    </dependencies>\r\n  </metadata> \r\n  <files>\r\n\r\n    <file src=\"" +
                    "..\\..\\..\\nuget-content\\install.ps1\" target=\"tools\\net35\" />\r\n    <file src=\"..\\." +
                    ".\\..\\nuget-content\\install.ps1\" target=\"tools\\net45\" />\r\n\r\n    <file src=\".\\bin\\" +
                    "Release\\net35\\");
            
            #line 91 "C:\dev\Xamarin\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["AssemblyName"]));
            
            #line default
            #line hidden
            this.Write(".dll\" target=\"lib\\net35\" />\r\n    <file src=\".\\bin\\Release\\net35\\");
            
            #line 92 "C:\dev\Xamarin\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["AssemblyName"]));
            
            #line default
            #line hidden
            this.Write(".xml\" target=\"lib\\net35\" />\r\n\t<file src=\".\\bin\\Release\\net35\\");
            
            #line 93 "C:\dev\Xamarin\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["AssemblyName"]));
            
            #line default
            #line hidden
            this.Write(".pdb\" target=\"lib\\net35\" />\r\n\r\n    <file src=\".\\bin\\Release\\net45\\");
            
            #line 95 "C:\dev\Xamarin\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["AssemblyName"]));
            
            #line default
            #line hidden
            this.Write(".dll\" target=\"lib\\net45\" />\r\n    <file src=\".\\bin\\Release\\net45\\");
            
            #line 96 "C:\dev\Xamarin\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["AssemblyName"]));
            
            #line default
            #line hidden
            this.Write(".xml\" target=\"lib\\net45\" />\r\n\t<file src=\".\\bin\\Release\\net45\\");
            
            #line 97 "C:\dev\Xamarin\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["AssemblyName"]));
            
            #line default
            #line hidden
            this.Write(".pdb\" target=\"lib\\net45\" />\r\n\r\n    <file src=\".\\bin\\Release\\pcl\\");
            
            #line 99 "C:\dev\Xamarin\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["AssemblyName"]));
            
            #line default
            #line hidden
            this.Write(".dll\" target=\"lib\\portable-net45+netcore45+wpa81+wp8+MonoAndroid10+xamarinios10+M" +
                    "onoTouch10\" />\r\n    <file src=\".\\bin\\Release\\pcl\\");
            
            #line 100 "C:\dev\Xamarin\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["AssemblyName"]));
            
            #line default
            #line hidden
            this.Write(".xml\" target=\"lib\\portable-net45+netcore45+wpa81+wp8+MonoAndroid10+xamarinios10+M" +
                    "onoTouch10\" />\r\n\t<file src=\".\\bin\\Release\\pcl\\");
            
            #line 101 "C:\dev\Xamarin\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["AssemblyName"]));
            
            #line default
            #line hidden
            this.Write(".pdb\" target=\"lib\\portable-net45+netcore45+wpa81+wp8+MonoAndroid10+xamarinios10+M" +
                    "onoTouch10\" />\r\n");
            
            #line 102 "C:\dev\Xamarin\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"
  
    if(((string)this.Session["AssemblyName"]).Equals("AWSSDK.MobileAnalytics",StringComparison.CurrentCultureIgnoreCase))
    {

            
            #line default
            #line hidden
            this.Write(@"    <file src="".\bin\Release\Xamarin.iOS10\AWSSDK.MobileAnalytics.dll"" target=""lib\Xamarin.iOS10"" />
    <file src="".\bin\Release\Xamarin.iOS10\AWSSDK.MobileAnalytics.xml"" target=""lib\Xamarin.iOS10"" />
    <file src="".\bin\Release\Xamarin.iOS10\AWSSDK.MobileAnalytics.pdb"" target=""lib\Xamarin.iOS10"" />
");
            
            #line 109 "C:\dev\Xamarin\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\NuGet\Nuspec.tt"

    }

            
            #line default
            #line hidden
            this.Write("  </files>\r\n</package>");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public class NuspecBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}