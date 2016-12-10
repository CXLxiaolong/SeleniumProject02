
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Support;

namespace MyDriver
{
    public class WebElement
    {
        public IWebElement Element;

        public WebElement(IWebElement webElement)
        {
            Element = webElement;
        }
        public void Click()
        {
            Log.DoLog("Click at the element");
            Element.Click();
        }
        public void Sendkeys(string value)
        {
            Log.DoLog("Click at the element");
            Element.SendKeys(value);

        }

        public string Text
        {
            get
            {
                Log.DoLog("Get element display text");
                return Element.Text;
            }
        }

        public List<WebElement> GetDropdownAllOptions()
        {
            Log.DoLog("Get Dropdown All Options");
            var select = new SelectElement(Element);
            return select.Options.Select(x=>new WebElement(x)).ToList();
        }

        public void SelectByIndex(int index)
        {
            Log.DoLog("Select Dropdown By Index "+index);
            var select = new SelectElement(Element);
            select.SelectByIndex(index);
        }

        public void SelectByText(string text)
        {
            Log.DoLog("Select Dropdown By Index" + text);
            var select = new SelectElement(Element);
            select.SelectByText(text);
        }
        public WebElement SelectedOption
        {
            get
            {
                Log.DoLog("get dropdown selected option");
                var select = new SelectElement(Element);
                return new WebElement(select.SelectedOption);
            }
        }

        public bool IsDisplayed
        {
            get
            {
                Log.DoLog("is Displayed");
                return Element.Displayed;
            }

        }

        public bool IsEnabled
        {
            get
            {
                Log.DoLog("is Enabled");
                return Element.Enabled;
            }
        }

        public bool Selected
        {
            get
            {
                Log.DoLog(" is selected");
                return Element.Selected;
            }
        }

        public void Clear()
        {
            Log.DoLog("Clear");
            Element.Clear();
        }

        public void Submit()
        {
            Log.DoLog("Submit");
            Element.Submit();
        }

















    }
}
