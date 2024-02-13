﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SqlFormatter
{
    internal class BaseFormatterState
    {
        public BaseFormatterState(bool htmlOutput)
        {
            HtmlOutput = htmlOutput;
        }

        protected bool HtmlOutput { get; set; }
        protected StringBuilder _outBuilder = new StringBuilder();

        public virtual void AddOutputContent(string content)
        {
            AddOutputContent(content, null);
        }

        public virtual void AddOutputContent(string content, string htmlClassName)
        {
            if (HtmlOutput)
            {
                if (!string.IsNullOrEmpty(htmlClassName))
                    _outBuilder.Append(@"<span class=""" + htmlClassName + @""">");
                _outBuilder.Append(Utils.HtmlEncode(content));
                if (!string.IsNullOrEmpty(htmlClassName))
                    _outBuilder.Append("</span>");
            }
            else
                _outBuilder.Append(content);
        }

        public virtual void OpenClass(string htmlClassName)
        {
            if (htmlClassName == null)
                throw new ArgumentNullException("htmlClassName");

            if (HtmlOutput)
                _outBuilder.Append(@"<span class=""" + htmlClassName + @""">");
        }

        public virtual void CloseClass()
        {
            if (HtmlOutput)
                _outBuilder.Append(@"</span>");
        }

        public virtual void AddOutputContentRaw(string content)
        {
            _outBuilder.Append(content);
        }

        public virtual void AddOutputLineBreak()
        {
            _outBuilder.Append(Environment.NewLine);
        }

        public string DumpOutput()
        {
            return _outBuilder.ToString();
        }

    }
}
