using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelDna.Integration;
using LakeFunctions;

namespace ExcelDNA
{
    public static class EquipFunctions
    {

        [ExcelFunction(Description = "", Category = "Equipment")]
        public static double 电机额定功率(double kwAxis)
        {
            return Motor.powern(kwAxis);
        }

        /// <summary>
        /// 电机功率,kW
        /// </summary>
        /// <param name="kwAxis">轴功率,kW</param>
        /// <param name="rem">放大系数,1.x</param>

        [ExcelFunction(Description = "", Category = "Equipment")]
        public static double 电机额定功率2(double kwAxis, double rem)
        {
            return Motor.powernExact(kwAxis, rem);
        }
        /// <summary>
        /// 0~100%
        /// </summary>
        /// <param name="flow">m3/hr</param>

        [ExcelFunction(Description = "", Category = "Equipment")]
        public static double 泵效率(double flow)
        {
            return Equipments.泵效率(flow);
        }
        /// <summary>
        /// 罗茨风机电机功率,kW
        /// </summary>
        /// <param name="flow">m3/min,实际状态下的气体流量</param>
        /// <param name="press">kPa</param>

        [ExcelFunction(Description = "", Category = "Equipment")]
        public static double 罗茨风机功率(double flow, double press)
        {
            return Equipments.罗茨风机功率.Invoke(flow).Invoke(press);
        }
        /// <summary>
        /// 查找箱子的搅拌器功率
        /// </summary>
        /// <param name="volume">m3</param>

        [ExcelFunction(Description = "", Category = "Equipment")]
        public static double 搅拌器功率(double volume)
        {
            return Equipments.搅拌器功率.Invoke(volume);
        }
        /// <summary>
        /// ton
        /// </summary>
        /// <param name="diameter">m</param>
        /// <param name="height">m</param>

        [ExcelFunction(Description = "", Category = "Equipment")]
        public static double 箱子重量(double diameter, double height)
        {
            return Equipments.箱子重量.Invoke(diameter).Invoke(height);
        }






    }
}
