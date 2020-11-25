using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidEx1
{
    //Який принцип S.O.L.I.D. порушено? Виправте!
    // Single responsibility principle
    class Item
    {

    }
    class Order
    {
        private List<Item> _itemList;

        internal List<Item> ItemList
        {
            get { return _itemList; }
            set { _itemList = value; }
        }
        public void GetItems() {/*...*/}
        public void AddItem(Item item) {/*...*/}
        public void DeleteItem(Item item) {/*...*/}

    }

    class OrderCalculations
    {
        public void CalculateTotalSum(Order order) {/*...*/}
        public void GetItemCount(Order order) {/*...*/}
    }

    class OrderRepository
    {
        public void Load(int orderId) {/*...*/}
        public void Save(Order order) {/*...*/}
        public void Update(Order order) {/*...*/}
        public void Delete(Order order) {/*...*/}
    }

    class PrintManager
    {
        public void PrintOrder(Order order) {/*...*/}
        public void ShowOrder(Order order) {/*...*/}
    }

    class Program
    {
        static void Main()
        {
            Console.ReadKey();
        }
    }
}

