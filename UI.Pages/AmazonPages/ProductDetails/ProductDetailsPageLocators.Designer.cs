﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UI.Pages.AmazonPages.ProductDetails {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ProductDetailsPageLocators {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ProductDetailsPageLocators() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("UI.Pages.AmazonPages.ProductDetails.ProductDetailsPageLocators", typeof(ProductDetailsPageLocators).Assembly);
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
        ///   Looks up a localized string similar to //input[@id=&apos;add-to-cart-button&apos;].
        /// </summary>
        internal static string AddToBacketButton {
            get {
                return ResourceManager.GetString("AddToBacketButton", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to //div[@id=&apos;huc-v2-order-row-container&apos;].
        /// </summary>
        internal static string NewItemInBasketNotification {
            get {
                return ResourceManager.GetString("NewItemInBasketNotification", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to //div[@class=&apos;badge-wrapper&apos;]/a.
        /// </summary>
        internal static string ProductBadge {
            get {
                return ResourceManager.GetString("ProductBadge", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to //span[@id=&apos;price&apos;].
        /// </summary>
        internal static string ProductPriceLabel {
            get {
                return ResourceManager.GetString("ProductPriceLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to //span[@id=&apos;productTitle&apos;].
        /// </summary>
        internal static string ProductTitleLabel {
            get {
                return ResourceManager.GetString("ProductTitleLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to //span[@class=&apos;a-button a-button-selected a-spacing-mini a-button-toggle format&apos;].
        /// </summary>
        internal static string SelectedFormatButton {
            get {
                return ResourceManager.GetString("SelectedFormatButton", resourceCulture);
            }
        }
    }
}