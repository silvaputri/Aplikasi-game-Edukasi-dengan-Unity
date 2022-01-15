using UnityEngine;

public interface IFactory
{
    GameObject FactoryMethod(int tag);
    //void FactoryMethod(int spawnEnemy);
}