string jsonFileName = "hi.txt";

var assembly = typeof(MainPage).GetTypeInfo().Assembly;
Stream r = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.{jsonFileName}");

using (var reader = new System.IO.StreamReader(r))
{
    var done = reader.ReadToEnd();
    guiLabel.Text = done;
}
     
        
