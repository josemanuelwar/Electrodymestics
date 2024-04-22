using Electrodymestics.enums;

namespace Electrodymestics.electrodymestics;
    public class WashingMachine :ElectrodyMestic
    {
       private double _load;

       public WashingMachine() {
            this._color= enumColor.WHITE;
            this._energyConsumption= "F";
            this._basePrice=100;
            this._weight=5;
            this._load=5;
       }

       public WashingMachine(double basePrice, double weight){
            this._basePrice=basePrice;
            this._weight=weight;
       }

        public WashingMachine(double basePrice, enumColor color, string energyConsumption, double weight,double load)
        : base(){
            this._basePrice=basePrice;
            this._color=color;
            this._weight=weight;
            this._energyConsumption=energyConsumption;
            this._load=load;

        }
       public double load{
        get{
            return this._load;
        }
        set{
            this._load=value;
        }
       }

        public override double FinalPrice()
        {
            double aux = 0;
            if(this._load>30){
                aux=50;
            }
            return base.FinalPrice()+aux;
        }
    }
