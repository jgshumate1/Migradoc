using MigraDoc.DocumentObjectModel;
using System;

namespace MigraDoc.Html
{
    public interface IConverter
    {
        Action<Section> Convert(ExCSS.Stylesheet sheet, string contents);
    }
}
