using AbyssPlugins;

namespace BasePlugin{
    public class HP:IStat{

        public string identificator{get;}
        int _hp;
        public int value{get{return _hp;}}

        public IStatControl control{get;set;}

        public HP(){
            identificator = "hp";
            _hp = 10;
        }
        public void IncValue(int value){
            _hp += value;
        }
        public void SubValue(int value){
            _hp -= value;
        }
    }
}
