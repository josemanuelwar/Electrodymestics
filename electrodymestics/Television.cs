using System;
using Electrodymestics.enums;
namespace Electrodymestics.electrodymestics
{
    public class Television : ElectrodyMestic
    {
        private double _resolution;
        private bool _TDT;

        private const int porciento=30;

        public Television(){
            this._color= enumColor.WHITE;
            this._energyConsumption= "F";
            this._basePrice=100;
            this._weight=5;
            this._resolution=20;
            this._TDT= false;
        }

        public Television(double basePrice,double weight):base(){
            this._basePrice=basePrice;
            this._weight=weight;
        }

        public Television(double basePrice, enumColor color, string energyConsumption, double weight,double resolution,bool TDT):base(){
             this._basePrice=basePrice;
            this._color=color;
            this._weight=weight;
            this._energyConsumption=energyConsumption;
            this._resolution=resolution;
            this._TDT=TDT;
        }


        public double resolution{
            get{
                return this._resolution;
            }
            set{
                this._resolution=value;
            }
        }

        public bool TDT{
            get{
                return this._TDT;
            }
            set{
                this._TDT=value;
            }
        }

        public override double FinalPrice()
        {
            double importe=base.FinalPrice();
            double porcentage=0;
            if(this.resolution>40){
                porcentage=(importe * porciento)/100;
            }
            importe=importe+porcentage;
            if(this._TDT){
                importe+=50;
            }
            return importe;
        }
    }
}