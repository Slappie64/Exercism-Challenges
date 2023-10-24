def response(hey_bob):
    """ Respond based on input string.

    :param hey_bob: string - A sentence given to our fictional teenager
    :return string - A response based on the incoming sentence.
    
    """
    
    hey_bob = hey_bob.strip()

    if hey_bob.isspace() or not hey_bob:
        return "Fine. Be that way!"

    if hey_bob[-1] == "?" and hey_bob.isupper():
        return "Calm down, I know what I'm doing!"
    
    if hey_bob[-1] == "?":
        return "Sure."
    
    if hey_bob.isupper():
        return "Whoa, chill out!"
    
    return "Whatever."