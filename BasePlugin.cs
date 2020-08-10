using AbyssPlugins;
using System.Collections.Generic;

namespace BasePlugin{
    public class BasePlugin:IPlugin{
        public string name{get;set;}
        public string description{get;set;}
        public List<string> identificators{get;set;}


        public BasePlugin(){
            name = "base game plugin";
            description = "contains all game content by anomalou";
            identificators = new List<string>();
        }
    }
}