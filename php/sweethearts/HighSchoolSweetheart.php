<?php

class HighSchoolSweetheart
{
    public function firstLetter(string $name): string
    {
        return $name[0];
    }

    public function initial(string $name): string
    {
        return $this->firstLetter($name) + ".";
    }

    public function initials(string $name): string
    {
        return $this->initial($this->firstLetter($name)) + $this->initial($name(strpos($name, " ")+1));
    }

    public function pair(string $sweetheart_a, string $sweetheart_b): string
    {
        throw new \BadFunctionCallException("Implement the function");
    }
}
