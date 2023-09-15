def steps(number):
    """Calculate Collatz Conjecture

    Param number: int - Input number to caluculate

    Take any positive integer n.
    If n is even, divide n by 2 to get n / 2.
    If n is odd, multiply n by 3 and add 1 to get 3n + 1.
    Repeat the process indefinitely.
    The conjecture states that no matter which number you start with, you will always reach 1 eventually.

    Given a number n, return the number of steps required to reach 1.
    """

    number_of_steps = 0

    if number <= 0:
        raise ValueError("Only positive integers are allowed")

    while number != 1:
        if number % 2 == 0:
            number = number / 2

        elif number % 2 != 0:
            number = (number*3)+1
            
        number_of_steps += 1

    return number_of_steps
