<?php

class PizzaPi
{
    public function calculateDoughRequirement($pizzas, $people)
    {/* Calculate the Dough Requirement

        The dough needed for the middle is a minimum 200g
        but every person it serves requires another 20g of dough.

        :param $pizzas: int - Number of pizzas
        :param $people: int - Number of people
        :return int: Amount of Dough required for the pizzas
    */
        return $pizzas*(($people * 20) + 200);
    }
    
    public function calculateSauceRequirement($pizzas)
    {/* Calculate the Sauce Requirement

        It takes 125mL of sauce per pizza, and each can is 250mL

        :param $pizzas: int - Number of pizzas
        :return int: - How many cans of sauce are required in total.
    */
        
        return (125 * $pizzas) / 250;
    }

    public function calculateCheeseCubeCoverage(
        $length, 
        $thickness, 
        $diameter)
    {/* Calculate the Cheese Cube Coverage

        Determine how many pizzas can  of some diameter (d) made from a cheese cube of side-length (l

        :param $length: int - Length of the block of cheese
        :param $thickness: float - Thickness of the cheese layer
        :param $diameter: int - Diameter of the pizza
        :return int: Rounded down total of coverage.
    */
        return floor(($length**3) / ($thickness * 3.14 * $diameter));
    }

    public function calculateLeftOverSlices($pizzas, $friends)
    {/* Calculate the Left Over Slices

        Lilly wants her pizzas to divide into 8 slices each and distributed evenly among her friends.

        :param $pizzas: int - Number of pizzas
        :param $friends: int - Number of friends.
        :return int: How many slices left over is everyone gets an even amount.
    */
        return ($pizzas * 8) % $friends;
    }
}
