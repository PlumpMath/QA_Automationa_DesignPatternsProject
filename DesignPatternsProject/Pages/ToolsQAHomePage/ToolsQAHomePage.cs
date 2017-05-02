﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace DesignPatternsProject.Pages.ToolsQAHomePage
{
    public partial class ToolsQAHomePage:BasePage
    {
        public ToolsQAHomePage(IWebDriver driver)
            : base(driver, "", "toolsQAURL")
        {
        }
    }
}
