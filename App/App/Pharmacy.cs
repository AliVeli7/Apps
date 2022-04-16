using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Pharmacy
    {
        public static int MedicineLimit;
        List<Medicine> medicines = new List<Medicine>(MedicineLimit);


        public void AddMedicine(Medicine medicine)
        {
            foreach (var item in medicines)
            {
                if (medicine.Name == item.Name)
                {
                    throw new MedicineAlreadyExistsException("Already Exist");
                }
            }

            if (MedicineLimit > medicines.Count)
            {
                medicines.Add(medicine);
            }
            else
            {
                throw new CapacityLimitException("Capacity Limit");
            }
        }


        public void GetAllMedicines()
        {
            foreach (var medicine in medicines)
            {
                if (medicine.IsDeleted==false)
                {
                    Console.WriteLine($"Id: {medicine.Id} Name: {medicine.Name} Price: {medicine.Price} Count: {medicine.Count} IsDeleted: {medicine.IsDeleted}");
                }
            }
        }

        public void FilterMedicinesByPrice(double MinPrice, double MaxPrice)
        {
            foreach (var medicine in medicines)
            {
                if (medicine.Price>=MinPrice&&medicine.Price<=MaxPrice)
                {
                    Console.WriteLine($"Id: {medicine.Id} Name: {medicine.Name} Price: {medicine.Price} Count: {medicine.Count} IsDeleted: {medicine.IsDeleted}");
                }
            }
        }

        public void GetMedicineByld(int? id)
        {
            bool isExist = false;
            if (id==null)
            {
                throw new NullReferanceException("Null Referance");

            }
            else
            {
                foreach (var medicine in medicines)
                {
                    if (medicine.Id==id&&medicine.IsDeleted==false)
                    {
                        isExist = true;
                        Console.WriteLine($"Id: {medicine.Id} Name: {medicine.Name} Price: {medicine.Price} Count: {medicine.Count} IsDeleted: {medicine.IsDeleted}");
                    }
                }
            }

            if (isExist == false)
            {
                throw new DllNotFoundException("Not Found");
            }
        }


        public void DeleteMedicineByld(int? id)
        {
            bool isExist=false;
            if (id == null)
            {
                throw new NullReferanceException("Null Referance");

            }
            else
            {
                foreach (var medicine in medicines)
                {
                    if (medicine.Id == id && medicine.IsDeleted == false)
                    {
                        isExist = true;
                        medicine.IsDeleted = true;
                    }
                }
            }

            if (isExist==false)
            {
                throw new DllNotFoundException("Not Found");
            }
        }

        public void EditMedicineEmail(int? id,string name)
        {
            bool isExist = false;
            if (id == null||name==null)
            {
                throw new NullReferanceException("Null Referance");

            }
            else
            {

                foreach (var medicine in medicines)
                {
                    if (name==medicine.Name)
                    {

                    }
                }
                foreach (var medicine in medicines)
                {
                    if (medicine.Id == id && medicine.IsDeleted == false)
                    {
                        isExist = true;
                        foreach (var item in medicines)
                        {
                            if (item.Name == name)
                            {
                               Console.WriteLine("name is exist");
                            }
                        }
                        medicine.Name = name;
                    }
                }
            }

            if (isExist == false)
            {
                throw new DllNotFoundException("Not Found");
            }
        }
    }
}
