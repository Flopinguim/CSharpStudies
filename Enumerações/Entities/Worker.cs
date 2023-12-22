using Enumerações.Entities.Enums;

namespace Enumerações.Entities
{
    public class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament departament { get; set; }
        public List<HourContract> hourContracts { get; set; }

        public Worker()
        {
            Name = string.Empty;
            Level = 0;
            BaseSalary = 0;
            departament = new Departament();
            hourContracts = new List<HourContract>();
        }

        public void addContract(HourContract contract) => hourContracts.Add(contract);
        public void removeContract(HourContract contract) => hourContracts.Remove(contract);
        public double income(int year, int month)
        {
            double valor = 0;
            foreach(HourContract contracts in hourContracts)
            {                
                if(contracts.Date.Month.Equals(month) && contracts.Date.Year.Equals(year))
                    valor =+ contracts.totalValue();
            }
            return valor + BaseSalary;
        }
    }
}
