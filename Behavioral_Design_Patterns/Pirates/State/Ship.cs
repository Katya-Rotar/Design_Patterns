using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Design_Patterns.Pirates.State
{
    public class Ship
    {
        private IShipState _state;

        public Ship()
        {
            _state = new FloatingState();  // Початковий стан: корабель плаває
        }

        public void SetState(IShipState state)
        {
            _state = state;
        }

        public void Move()
        {
            _state.Move();
        }

        public void Attack()
        {
            _state.Attack();
        }

        public void Repair()
        {
            _state.Repair();
        }
        public void UnloadCargo() {
            _state.UnloadCargo();
        }
    }
}