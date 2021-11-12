using Microsoft.AspNetCore.Components;
using System;

namespace SalaryBonusCalculators.Data
{
    enum Format
    {
        Currency,
        Percent,
        None
    }

    public class BonusCalculation : ComponentBase
    {
        
        double K16 = 0;
        private double P2P => P2 / 100;
        private double N2P => N2 / 100;
        private double L15P => L15 / 100;

        public string EmployeeName { get; set; }

        public double L13{ get; set; }
        public string L13String { get; set; }
        public double L14{get; set;}
        public string L14String { get; set; }

        public double L15 { get; set; }
        public string L15String { get; set; }

        public double R2 { get; set; }
        public string R2String { get; set; }
        public double Q2 { get; set; }
        public string Q2String { get; set; }

        public double L2 { get; set; }
        public string L2String { get; set; }

        public double M2 { get; set; }
        public string M2String { get; set; }
        public double N2 { get; set; }
        public string N2String { get; set; }
        public double O2 { get; set; }
        public string O2String { get; set; }

        public double P2 { get; set; }
        public string P2String { get; set; }

        public double L4 { get; set; }
        public string L4String { get; set; }

        public double M4 { get; set; }
        public string M4String { get; set; }

        public double N4 { get; set; }
        public string N4String { get; set; }

        public double O4 { get; set; }
        public string O4String { get; set; }

        public double P4 { get; set; }
        public string P4String { get; set; }

        public double Q4 { get; set; }
        public string Q4String { get; set; }

        public double R4 { get; set; }
        public string R4String { get; set; }

        public double L6 { get; set; }
        public string L6String { get; set; }

        public double M6 { get; set; }
        public string M6String { get; set; }

        public double N6 { get; set; }
        public string N6String { get; set; }

        public double O6 { get; set; }
        public string O6String { get; set; }

        public double P6 { get; set; }
        public string P6String { get; set; }

        public double Q6 { get; set; }
        public string Q6String { get; set; }

        public double R6 { get; set; }
        public string R6String { get; set; }

        public string J16
        {
            get; set;
        }
        public double Sum { get; set; }
        public string SumString { get; set; }

        public void CalculateBonus()
        {
            Q2 = L13;
            R2 = this.L14 == 0 ? Q2 : this.L14;
            var l2Value = (Q2 > O2) ? (Q2 - O2) * P2P + (O2 - M2) * N2P : (Q2 > M2 ? (Q2 - M2) * N2P : 0);
            L2 = Math.Round(l2Value, 1);
            L4 = ((Q2 >= N4 && Q2 < N6) ? O4 : 0);
            M4 = (K16 >= 1 ? 0 : ((R2 >= P4 && R2 < P6) ? Q4 : 0));
            R4 = Math.Round(Q2 * L15P, 0);
            L6 = (Q2 >= N6 ? O6 : 0);
            M6 = (K16 >= 1 ? 0 : (R2 >= P6 ? Q6 : 0));
            R6 = R4 + L2 + (L4 + M4) + (L6 + M6);
            Sum = R4 + L2 + L4 + M4 + L6 + M6;
        }
    }
}
