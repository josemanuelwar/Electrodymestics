using Electrodymestics.enums;

namespace Electrodymestics.electrodymestics;
    public class ElectrodyMestic
    {
        protected double _basePrice;

        protected enumColor _color;

        protected Dictionary<string,int> _tableEnergyConsumption = new Dictionary<string, int>(){
            {"A",100},
            {"B",80},
            {"C",60},
            {"D",50},
            {"E",30},
            {"F",10}
        };

        protected string _energyConsumption;
        protected double _weight;

        public ElectrodyMestic(){
            this._color= enumColor.WHITE;
            this._energyConsumption= "F";
            this._basePrice=100;
            this._weight=5;


        }

        public ElectrodyMestic(double basePrice, double weight){
            this._basePrice=basePrice;
            this._weight=weight;
        }

        public ElectrodyMestic(double basePrice, enumColor color, string energyConsumption, double weight){
            this._basePrice=basePrice;
            this._color=color;
            this._weight=weight;
            this._energyConsumption=energyConsumption;
        }

        public double basePrice {
            get{
                return this._basePrice;
            }
            set{
                this._basePrice=value;
            }
        }

        public enumColor color{
            get{
                return this._color;
            }
            set{
                this._color=value;
            }
        }

        public string energyConsumption{
            get{
                return this._energyConsumption;
            }
            set{
                this._energyConsumption=value;
            }
        }

        public double weight{
            get{
                return this._weight;
            }
            set{
                this._weight=value;
            }
        }

        public void checkEnergyConsumption(string energyConsumption){
            double aux = this._tableEnergyConsumption[energyConsumption];
            if(aux < 0){
                this._energyConsumption=energyConsumption;
            }else{
                Console.WriteLine("No se encuntra en la tabla de consumo energetico");
            }
        }
        
        public virtual double FinalPrice(){
            if(this._weight<=19){
                this._basePrice=10;
            }
            if(this._weight>19 && this._weight<= 49){
                this._basePrice=50;
            }
            if(this._weight>49 && this._weight <= 79){
                this._basePrice = 80;
            }
            if(this._weight>= 80){
                this.basePrice=100;
            }
            double aux = this._tableEnergyConsumption[this._energyConsumption];
            if(aux < 0){
                this._basePrice=aux+this._basePrice;

            }
            return this._basePrice;
        }
        
    }