def is_valid(sides):
    """Return True or False whether the sides provided produce a valid triangle.

    :param sides: list - 3 numbers corresponding to sides of a triangle.
    :return: bool - True or False depending on met conditions.

    All items in sides must not be empty and the sum of all sides must be larger or
    equal to the largest side multiplied by 2    
    """

    return all(sides) and (sum(sides) >= max(sides)*2)

def equilateral(sides):
    """Return True or False whether the sides provided produce a valid EQUILATERAL triangle.

    :param sides: list - 3 numbers corresponding to sides of a triangle.
    :return: bool - True or False depending on met conditions.
    
    """
    print(f"Sides: {sides}\n Set: {len(set(sides))}")
    return is_valid(sides) and len(set(sides)) == 1

def isosceles(sides):
    """Return True or False whether the sides provided produce a valid ISCSCELES triangle.

    :param sides: list - 3 numbers corresponding to sides of a triangle.
    :return: bool - True or False depending on met conditions.
    """

    return is_valid(sides) and len(set(sides)) < 3

def scalene(sides):
    """Return True or False whether the sides provided produce a valid SCALENE triangle.

    :param sides: list - 3 numbers corresponding to sides of a triangle.
    :return: bool - True or False depending on met conditions.
    """

    return is_valid(sides) and len(set(sides)) == 3