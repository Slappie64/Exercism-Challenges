"""Functions used in preparing Guido's gorgeous lasagna.

Learn about Guido, the creator of the Python language:
https://en.wikipedia.org/wiki/Guido_van_Rossum

This is a module docstring, used to describe the functionality
of a module and its functions and/or classes.
"""


#TODO: define the 'EXPECTED_BAKE_TIME' constant.
EXPECTED_BAKE_TIME = 40
TIME_PER_LAYER = 2

#TODO: Remove 'pass' and complete the 'bake_time_remaining()' function below.
def bake_time_remaining(elapsed_time):
    """Calculate the bake time remaining.

    :param: elapsed_bake_time: int - baking time already elapsed.
    :return: int - remaining bake time (in minutes) derived from 'EXPECTED_BAKE_TIME'.

    Function that takes the actual minutes the lasagna has been in the oven as
    an argument and returns how many minutes the lasagna still needs to bake
    based on the `EXPECTED_BAKE_TIME`.
    """
    time_remaining = EXPECTED_BAKE_TIME - elapsed_time
    return time_remaining


#TODO: Define the 'preparation_time_in_minutes()' function below.
# You might also consider using 'PREPARATION_TIME' here, if you have it defined.
def preparation_time_in_minutes(number_of_layers):
    """Calculate the preparation time in minutes.
    
    :param number_of_layers: int - The number of layers required.
    :return: int - Total time (in minutes) based on the number of layers.

    Function that takes a number of layers and calculates the total bake time for
    the entire lasagne by multiplying the time per layer and the number of layers.
    """
    preparation_time_in_minutes = number_of_layers * TIME_PER_LAYER
    return preparation_time_in_minutes


#TODO: define the 'elapsed_time_in_minutes()' function below.
# Remember to add a docstring (you can copy and then alter the one from bake_time_remaining.)
def elapsed_time_in_minutes(layers, time_remaining):
    """Calculate the total elapsed cooking time, including preparation.
    
    :param layers int: - the number of layers required.
    :param time_remaining: int - The amount of time remaining.

    Function that calculates the total amount of time elapsed for cooking and preparing 
    calculated based on the number of layers and the time remaining.
    """
    return preparation_time_in_minutes(layers) + time_remaining