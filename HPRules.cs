using AbyssPlugins;
using System;

namespace BasePlugin{
    public class HPRules:IGameRule{
        
        public string identificator{get;}
        public IGameRuleControl control{get;set;}


        public HPRules(){
            identificator = "hp_rules";
        }
        public bool CheckRule(){
            if(control.GetStat("hp").value > 0)
                return true;
            else
                return false;
        }

        public void Behaviour(){
            System.Console.WriteLine(control.GetStat("hp").value);
        }

        public void IfBreakRule(){
            System.Console.WriteLine("You are died");
        }
    }
}