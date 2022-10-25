﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Study.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class DataBaseProperties {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal DataBaseProperties() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Study.Properties.DataBaseProperties", typeof(DataBaseProperties).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TABLE IF NOT EXISTS Bombs (Id INTEGER PRIMARY KEY NOT NULL, &quot; +
        ///                &quot;score INTEGER NOT NULL, FOREIGN KEY (Id) REFERENCES UserScores (Id) ON DELETE CASCADE);.
        /// </summary>
        internal static string CreateBombs {
            get {
                return ResourceManager.GetString("CreateBombs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TABLE IF NOT EXISTS UserScores (Id INTEGER PRIMARY KEY NOT NULL,&quot; +
        ///                &quot;name TEXT NOT NULL, result INTEGER NOT NULL);.
        /// </summary>
        internal static string CreateUserScores {
            get {
                return ResourceManager.GetString("CreateUserScores", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE VIEW IF NOT EXISTS Total (name, total) AS SELECT UserScores.name, SUM(UserScores.result + Bombs.score) AS total_score FROM UserScores INNER JOIN Bombs USING (Id) GROUP BY Id ORDER BY (UserScores.result + Bombs.score) DESC.
        /// </summary>
        internal static string CreateView {
            get {
                return ResourceManager.GetString("CreateView", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data Source=rating.db;Version=3;New=True;Compress=True;.
        /// </summary>
        internal static string DBConnection {
            get {
                return ResourceManager.GetString("DBConnection", resourceCulture);
            }
        }
    }
}
