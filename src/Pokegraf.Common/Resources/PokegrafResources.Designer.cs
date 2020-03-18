﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pokegraf.Common.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class PokegrafResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal PokegrafResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Pokegraf.Common.Resources.PokegrafResources", typeof(PokegrafResources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [pokegraf](https://github.com/elementh/pokegraf) is a bot made with ❤️ and gratitude by [Lucas Maximiliano Marino](https://lucasmarino.me/) with the help of [contributors](https://github.com/elementh/pokegraf/blob/master/CONTRIBUTORS.md)! 
        ///It uses the [PokeAPI](https://github.com/PokeAPI/pokeapi) and [Pokemon Fusion](https://pokemon.alexonsager.net/). 
        ///Pokémon ©1995 [pokémon](https://www.pokemon.com/), [nintendo](https://www.nintendo.com/), [game freak](https://www.gamefreak.co.jp/), [creatures](https://w [rest of string was truncated]&quot;;.
        /// </summary>
        public static string AboutText {
            get {
                return ResourceManager.GetString("AboutText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ups, there was an error! Try again later!.
        /// </summary>
        public static string DefaultErrorMessage {
            get {
                return ResourceManager.GetString("DefaultErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to More fusion!.
        /// </summary>
        public static string MoreFusion {
            get {
                return ResourceManager.GetString("MoreFusion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sorry but that name is too weird! Try again *Trainer*!.
        /// </summary>
        public static string SetNameErrorMessage {
            get {
                return ResourceManager.GetString("SetNameErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sorry *Trainer*, seems like I can&apos;t get you this data right now! Try again later!.
        /// </summary>
        public static string StatsErrorMessage {
            get {
                return ResourceManager.GetString("StatsErrorMessage", resourceCulture);
            }
        }
    }
}
