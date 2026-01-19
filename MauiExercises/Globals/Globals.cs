using MauiExercises.Models;

namespace MauiExercises.Globals
{
    public class Global

    {
        #region Lazy implementation
        private static Global _instance = null;
        Global() { } // just to avoid any direct instantiations
        public static Global Data => (_instance == null) ? _instance = new Global() : _instance;
        
        #endregion

        #region Data implementation 
        // accessible as GlobalData.Data.xx 
        public string Message { get; set; }
        public DateTime Time { get; set; }
        public Lazy<List<Friend>> Friends = new (() => Friend.Factory.CreateRandom(100));
        public Lazy<IEnumerable<NamedColor>> NamedColors = new(() => NamedColor.All);

        //Exercise:
        // Add properties so Global.Data contain a list of Friend,
        // a list of City, and a list on NamedColor
        #endregion
    }
}
