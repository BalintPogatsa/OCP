using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.ConsoleApp
{
  public class Button
  {
    public ContentType Type { get; set; }
    public string Content { get; set; }

    public string RenderAsXml()
    {
      if (Type == ContentType.Text)
      {
        return $"<button><text>{Content}</text></button>";
      }
      else if (Type == ContentType.Image)
      {
        return $"<button><img src=\"{Content}\" /></button>";
      }
      else
      {
        throw new NotSupportedException("Unsupported button type.");
      }
    }
  }
}
