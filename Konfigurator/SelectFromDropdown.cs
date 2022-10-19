/*
 * Created by Ranorex
 * User: brueckner
 * Date: 19.10.2022
 * Time: 08:56
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace Konfigurator
{
    /// <summary>
    /// Description of SelectFromDropdown.
    /// </summary>
    [TestModule("2B24FEC7-19E1-4B3A-AE7E-390F59560003", ModuleType.UserCode, 1)]
    public class SelectFromDropdown : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SelectFromDropdown()
        {
            // Do not delete - a parameterless constructor is required!
        }

string _KatalogName = "";
[TestVariable("b31d25ed-b9c7-4349-a469-72ec4268e35a")]
public string KatalogName
{
	get { return _KatalogName; }
	set { _KatalogName = value; }
}

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            Ranorex.WebElement dropdownItem = "/form[@title='Konfigurator']/dom[@domain='']/body/div/div/div/?/?/a[@innertext='" + _KatalogName + "']";
            dropdownItem.Click();
        }
    }
}
