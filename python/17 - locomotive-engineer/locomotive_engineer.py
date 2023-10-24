"""Functions which helps the locomotive engineer to keep track of the train."""


def get_list_of_wagons(*wagon_ids):
    """Return a list of wagons.

    :param: arbitrary number of wagons.
    :return: list - list of wagons.
    """

    return list(wagon_ids)


def fix_list_of_wagons(each_wagons_id, missing_wagons):
    """Fix the list of wagons.

    :parm each_wagons_id: list - the list of wagons.
    :parm missing_wagons: list - the list of missing wagons.
    :return: list - list of wagons.
    """

    wagon_one, wagon_two, locomotive, *wagon_list = each_wagons_id

    return [locomotive,*missing_wagons,*wagon_list, wagon_one, wagon_two]

def add_missing_stops(start_finish, **stops):
    """Add missing stops to route dict.

    :param route: dict - the dict of routing information.
    :param: arbitrary number of stops.
    :return: dict - updated route dictionary.
    """

    return {**start_finish, "stops":list(stops.values())}


def extend_route_information(route, more_route_information):
    """Extend route information with more_route_information.

    :param route: dict - the route information.
    :param more_route_information: dict -  extra route information.
    :return: dict - extended route information.
    """
    
    return {**route, **more_route_information}

def fix_wagon_depot(wagons_rows):
    """Fix the list of rows of wagons.

    :param wagons_rows: list[list[tuple]] - the list of rows of wagons.
    :return: list[list[tuple]] - list of rows of wagons.
    """
    [*row_one],[*row_two],[*row_three] = zip(*wagons_rows)

    return [row_one, row_two,row_three]


    
