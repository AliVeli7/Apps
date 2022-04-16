using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Pharmacy.MedicineLimit = 5;
            Pharmacy pharmacy = new Pharmacy();
            Medicine medicine1 = new Medicine("A",100,10);
            Medicine medicine2 = new Medicine("B",432,12);
            Medicine medicine3 = new Medicine("C",100,12);
            Medicine medicine4 = new Medicine("R",1234,22);

            pharmacy.AddMedicine(medicine1);
            pharmacy.AddMedicine(medicine2);
            pharmacy.AddMedicine(medicine3);
            pharmacy.AddMedicine(medicine4);
            pharmacy.GetAllMedicines();
            pharmacy.EditMedicineEmail(2, "T");
            pharmacy.GetMedicineByld(2);
            pharmacy.DeleteMedicineByld(3);
            pharmacy.FilterMedicinesByPrice(0, 600);



        }
    }
}
