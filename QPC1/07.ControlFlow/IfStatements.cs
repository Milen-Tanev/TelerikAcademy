Potato potato;
//... 

if (potato == null)
{
    throw new ArgumentNullException("Potato cannot be null!");
}

bool potatoIsNotRotten = !potato.IsRotten;
if (potato.HasBeenPeeled && potatoIsNotRotten)
{
    Cook(potato);
}

// parentheses were useless in this case, since all prerequisites must be met
bool isXInRange = x >= MinX && x <= MaxX;
bool isYInRange = y >= MinY && y <= MaxY;

if (isXInRange && isYInRange && !shouldNotVisitCell)
{
    VisitCell();
}