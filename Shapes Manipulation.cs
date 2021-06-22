/*This programme was a research project in the first year for me in electrical engineering department, at the Higher institute of engineering and technology Kafr El Sheikh*/


/*Research Project 1 (Shapes model)
Design and implement an object model for shapes manipulation. Your object model should contain an inheritance hierarchy containing a parent shape with the general shared shape properties/attributes and methods. Put as much as you can for the shapes in the hierarchy each with the full details of methods and properties/attributes. Write a C# program to demonstrate your design and implementation. Your project should contain, at least, the following main parts:
	Your description of the model
	Your high-level design of the model using sketching and drawing
	Your implementation in C# including a test program
	Screenshots from the output of a test program
*/



using System;
using System.Collections.Generic;
using System.Linq;	
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp1
{
    public class Shape
    {
        public Shape() { }
        
        public virtual double getArea() { return 0; } //For 2d shapes , it calculates the area
        public virtual double getperimeter() { return 0; } //For 2d shapes , it calculates the perimeter
        public virtual double getSideArea() { return 0; } //For 3d shapes , it calculates the side area
        public virtual double getTotalArea() { return 0; } //For 3d shapes , it calculates the total area
        public virtual double getVolume() { return 0; } //For 3d shapes , it calculates the volume
    }
    class Square : Shape // This is inheritance and we did this to get all the properties of class Shape into the following classes.
    {
        public double Side { get; set; }
        public Square(double s) { this.Side = s; }
        public override double getArea() { return Math.Pow(Side,2); }
        public override double getperimeter() { return Side * 4; } 
    }
    class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public Rectangle(double L, double W) { this.Length = L; this.Width = W; }
        public override double getArea() { return Length * Width; }
        public override double getperimeter() { return (Width + Length) * 2  ; }
    }
    class Circle : Shape
    {
        public double radius { get; set; }
        public Circle(double r) { this.radius = r; }
        public override double getArea() { return (3.14 * Math.Pow(radius,2)); }
        public override double getperimeter() {  return (2 * 3.14 * radius); }
    }
    class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public Triangle(double B, double H) { this.Base = B; this.Height = H; }
        public override double getArea() { return ((.5 * Base) * Height); }
    }
    class Rhombus : Shape
    {
        public double Side { get; set; }
        public double Height { get; set; }
        public Rhombus(double B, double H) { this.Side = B; this.Height = H; }
        public override double getArea() { return (Side * Height); }
        public override double getperimeter() { return ( 4 * Side ); }
    }
    class Cube : Shape
    {
        public double Side { get; set; }
        public Cube(double S) { this.Side = S; }
        public override double getSideArea() { return (4 * Math.Pow(Side, 2)); }
        public override double getTotalArea() { return (6 * Math.Pow(Side, 2)); }
        public override double getVolume() { return (Math.Pow(Side, 3)); }    
    }
    class Cylinder : Shape
    {
        public double radius { get; set; }
        public double Height { get; set; }
        public Cylinder(double r, double H) { this.radius = r; this.Height = H; }
        public override double getSideArea() { return (2 * 3.14 * radius * Height); }
        public override double getTotalArea() { return (2 * 3.14 * radius * Height)+(2 * 3.14 * Math.Pow(radius,2)); }
        public override double getVolume() { return (3.14 * Math.Pow(radius, 2) * Height); }
    }
    class Sphere : Shape
    {
        public double radius { get; set; }
        public Sphere(double r) { this.radius = r; }
        public override double getTotalArea() { return (4 * 3.14 * Math.Pow(radius, 3)); }
        public override double getVolume() { return (1.3333333333333 * 3.14 * Math.Pow(radius, 3)); }  //1.33333 equals to 4/3
    }
    class Cone : Shape 
    {
        public double radius { get; set; }
        public double Height { get; set; }
        public double SideHeight { get; set; }
        public Cone(double r, double H, double SH) { this.radius = r; this.Height = H; this.SideHeight = SH; }
        public override double getSideArea() { return (3.14 * radius * SideHeight); }
        public override double getTotalArea() { return (3.14 * radius * SideHeight) + (3.14 * Math.Pow(radius,2)); }
        public override double getVolume() { return (0.333333333333 * 3.14 * Math.Pow(radius, 2) * Height); }
    }
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("This Programme calculates the following shapes' Areas and Perimeters, just enter the required values to get the results");
                Console.WriteLine("- - - - - - - - - - Let's begin - - - - - - - - - -");
                double q, w, e, r, t, y, u, i, o, p, a, d, m, n, z; // Variables Declaration
        /*--- --- --- ----- ---- ---- --- ---- ------ ---- --- The Square --- --- --- ----- ---- ---- --- ---- ------ ---- ---*/
                Console.Write("Enter the Square side value : ");
                q = double.Parse(Console.ReadLine());
                Shape Sq = new Square(q);
                Console.WriteLine("The Square area      = " + Sq.getArea() + "\n"
                                                + "The Square perimeter = " + Sq.getperimeter());
                Console.WriteLine("- - - - - - - - - - - - - - - - - - -");
        /*--- --- --- ----- ---- ---- --- ---- ------ ---- --- The Rectangle --- --- --- ----- ---- ---- --- ---- ------ ---- ---*/
                Console.Write("Enter the Rectangle length value : ");
                w = double.Parse(Console.ReadLine());
                Console.Write("Enter the Rectangle width value : ");
                e = double.Parse(Console.ReadLine());
                Shape rect = new Rectangle(w, e);
                Console.WriteLine("The Rectangle area      = " + rect.getArea() + "\n"
                                                + "The Rectangle perimeter = " + rect.getperimeter());
                Console.WriteLine("- - - - - - - - - - - - - - - - - - -");
        /*--- --- --- ----- ---- ---- --- ---- ------ ---- --- The Circle --- --- --- ----- ---- ---- --- ---- ------ ---- ---*/
                Console.Write("Enter the Circle radius value : ");
                r = double.Parse(Console.ReadLine());
                Shape Cr = new Circle(r);
                Console.WriteLine("The Circle area      = " + Cr.getArea() + "\n"
                                                + "The Circle perimeter = " + Cr.getperimeter());
                Console.WriteLine("- - - - - - - - - - - - - - - - - - -");
        /*--- --- --- ----- ---- ---- --- ---- ------ ---- --- The Triangle --- --- --- ----- ---- ---- --- ---- ------ ---- ---*/
                Console.Write("Enter the Triangle Base value : ");
                t = double.Parse(Console.ReadLine());
                Console.Write("Enter the Triangle Height value : ");
                y = double.Parse(Console.ReadLine());
                Shape Tr = new Triangle(t, y);
                Console.WriteLine("The Triangle area = " + Tr.getArea());
                Console.WriteLine("- - - - - - - - - - - - - - - - - - -");
        /*--- --- --- ----- ---- ---- --- ---- ------ ---- --- The Rhombus --- --- --- ----- ---- ---- --- ---- ------ ---- ---*/
                Console.Write("Enter the Rhombus Side value   : ");
                u = double.Parse(Console.ReadLine());
                Console.Write("Enter the Rhombus Height value : ");
                i = double.Parse(Console.ReadLine());
                Shape Rh = new Rhombus(u, i);
                Console.WriteLine("The Rhombus area      = " + Rh.getArea() + "\n"
                                                + "The Rhombus perimeter = " + Rh.getperimeter());
                Console.WriteLine("- - - - - - - - - - - - - - - - - - -");
        /*--- --- --- ----- ---- ---- --- ---- ------ ---- ---The Cube --- --- --- ----- ---- ---- --- ---- ------ ---- ---*/
                Console.Write("Enter the Cube side value : ");
                o = double.Parse(Console.ReadLine());
                Shape Cu = new Cube(o);
                Console.WriteLine("The Cube Side Area  = " + Cu.getSideArea()  + "\n"
                                                + "The Cube Total Area = " + Cu.getTotalArea() + "\n"
                                                + "The Cube Volume     = " + Cu.getVolume());
                Console.WriteLine("- - - - - - - - - - - - - - - - - - -");
        /*--- --- --- ----- ---- ---- --- ---- ------ ---- ---The Cylinder --- --- --- ----- ---- ---- --- ---- ------ ---- ---*/
                Console.Write("Enter the Cylinder radius value : ");
                p = double.Parse(Console.ReadLine());
                Console.Write("Enter the Cylinder Height value : ");
                a = double.Parse(Console.ReadLine());
                Shape Cy = new Cylinder(p,a);
                Console.WriteLine("The Cylinder Side Area  = " + Cy.getSideArea()  + "\n"
                                                + "The Cylinder Total Area = " + Cy.getTotalArea() + "\n"
                                                + "The Cylinder Volume     = " + Cy.getVolume());
                Console.WriteLine("- - - - - - - - - - - - - - - - - - -");
        /*--- --- --- ----- ---- ---- --- ---- ------ ---- ---The Sphere --- --- --- ----- ---- ---- --- ---- ------ ---- ---*/
                Console.Write("Enter the Sphere radius value : ");
                d = double.Parse(Console.ReadLine());
                Shape Sp = new Sphere(d);
                Console.WriteLine("The Cube Total Area = " + Sp.getTotalArea() + "\n"
                                                + "The Cube Volume     = " + Sp.getVolume());
       Console.WriteLine("- - - - - - - - - - - - - - - - - - -");
        /*--- --- --- ----- ---- ---- --- ---- ------ ---- ---The Cone --- --- --- ----- ---- ---- --- ---- ------ ---- ---*/
                Console.Write("Enter the Cone radius value : ");
                m = double.Parse(Console.ReadLine());
                Console.Write("Enter the Cone Height value : ");
                n = double.Parse(Console.ReadLine());
                Console.Write("Enter the Cone Side Height value : ");
                z = double.Parse(Console.ReadLine());
                Shape Co = new Cone(m, n,z);
                Console.WriteLine("The Cone Side Area  = " + Co.getSideArea()  + "\n"
                                                + "The Cone Total Area = " + Co.getTotalArea() + "\n"
                                                + "The Cone Volume     = " + Co.getVolume());
            } catch (Exception ex) { Console.WriteLine(ex.Message); }
            Console.Read();
        }
    }
}
