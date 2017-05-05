using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extentionerwf
{
    public class ExtensionSetter
    {
        public IEnumerable<string> Set(string path, string toExtension = "")
        {
            var exists = !string.IsNullOrWhiteSpace(path) && System.IO.Directory.Exists(path);
            if (!exists) throw new ArgumentException($"Path \"{path}\" doesn't exist.");
            foreach (var f in System.IO.Directory.GetFiles(path))
            {
                var newF = System.IO.Path.ChangeExtension(f, toExtension);
                System.IO.File.Move(f, newF);
                yield return f;
            }
        }
    }
}
