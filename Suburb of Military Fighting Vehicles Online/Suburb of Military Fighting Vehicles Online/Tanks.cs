using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
public class Tanks
{
    int direction;
    int shootingDirection;
    int top;
    int left;
    int width = 100;
    int height = 100;
    int bullets = 0;
    bool isDisabled;
    //direction values stop = 0
    //up = 1, right = 2, down= 3, left= 4
    public const int maxBullets = 1;
    public Tanks(int ulX, int ulY)
    {
        top = ulY;
        left = ulX;
        direction = 0;
        shootingDirection = 1;
        isDisabled = false;
    }

    public void SetDirection(int dir)
    {
        direction = dir;
        if (dir != 0)
        {
            shootingDirection = dir;
        }
    }

    public int getDirection()
    {
        return direction;
    }

    public int getSDirection()
    {
        return shootingDirection;
    }
    public bool addBullet()
    {
        if (bullets == maxBullets)
        {
            return false;
        }
        else
        {
            bullets = bullets + 1;
            return true;
        }
    }
    public bool removeBullet()
    {
        if (bullets <= 0)
        {
            return false;
        }
        else
        {
            bullets = bullets - 1;
            return true;
        }
    }
    public void disable()
    {
        isDisabled = true;
    }
    public bool disabledStatus()
    {
        return isDisabled;
    }
    public void enable()
    {
        isDisabled = false;
    }
    public int getBullets()
    {
        return bullets;
    }

}