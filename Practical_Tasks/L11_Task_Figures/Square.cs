namespace L11_Task_Figures
{
    class Square : IFigureArea, IFigurePrint
    {
        public int Edge { get; set; }
        public Square(int edge) => Edge = edge;
        public double Area() => Edge ^ 2;

        public override string ToString() => $"This is {this.GetType().Name}. CLR Type in {this.GetType()}. Square is {Area()}";  
    }
}
