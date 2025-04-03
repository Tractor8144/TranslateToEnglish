using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Extensibility;

namespace TranslateExtension
{
    internal class TextService
    {
        private Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot _textSnapShot;

        public TextService(Microsoft.VisualStudio.Extensibility.Editor.ITextViewSnapshot textSnapShot)
        {
            this._textSnapShot = textSnapShot;
        }
        public string GetSelectedText()
        {
            var selectedText = "";
            int startIndex = this._textSnapShot.Selection.Start.Offset;
            int endIndex = _textSnapShot.Selection.End.Offset;
            for (int i = startIndex; i < endIndex; i++)
            {
                selectedText += _textSnapShot.Document.Text[i];
            }
            return selectedText;
        }
        //public void ReplaceSelectedText(string newText)
        //{
        //    int startIndex = _textSnapShot.Selection.Start.Offset;
        //    int endIndex = _textSnapShot.Selection.End.Offset;
        //    Microsoft.VisualStudio.Extensibility.Editor.TextRange range = new Microsoft.VisualStudio.Extensibility.Editor.TextRange(_textSnapShot.Selection.Start, endIndex - startIndex);
        //    _textSnapShot.Document.Repalce(range, newText);
        //}

    }
}
