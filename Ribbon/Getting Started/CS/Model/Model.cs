#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RibbonSample
{
    /// <summary>
    /// Represents a control that displays the data.
    /// </summary>
    class Model
    {
        #region Fields
        /// <summary>
        /// Maintains the font family for RibbonComboBox Control.
        /// </summary>
        private string fontfamily;

        /// <summary>
        /// Maintains the font size for RibbonComboBox Control.
        /// </summary>
        private int fontsize;
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the font family of the <see cref="Model"/> class.
        /// </summary>     
        public string FontFamily
        {
            get { return fontfamily; }
            set { fontfamily = value; }
        }

        /// <summary>
        /// Gets or sets the font size of the <see cref="Model"/> class.
        /// </summary>     
        public int FontSize
        {
            get { return fontsize; }
            set { fontsize = value; }
        }
        #endregion
    }
}