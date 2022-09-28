using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    abstract class ICar
    {
        protected float _speed;
        protected float _velocity;
        protected float _maxSpeed;
        public virtual void MoveForward() {
            if (_speed < _maxSpeed)
                _speed += _velocity;
        }
        public virtual void MoveBack()
        {
            if (_speed > 0)
                _speed -= _velocity;
        }

        public string InfOfCar()
        {
            return this.ToString();
        }
    }

    class SportCar : ICar
    {
        public SportCar()
        {
            _speed = 0f;
            _velocity = 15f;
            _maxSpeed = 250f;
        }
        /*public override void MoveForward()
        {
            if (_speed < _maxSpeed)
                _speed += _velocity;
        }

        public override void MoveBack()
        {
            if (_speed > 0)
                _speed -= _velocity;
        }*/
    }

    class BaseCar : ICar
    {
        public BaseCar() {
            _speed = 0f;
            _velocity = 9f;
            _maxSpeed = 180f;
        }
        /*public override void MoveForward()
        {
            if (_speed < _maxSpeed)
                _speed += _velocity;
        }

        public override void MoveBack()
        {
            if (_speed > 0)
                _speed -= _velocity;
        }*/
    }
}
