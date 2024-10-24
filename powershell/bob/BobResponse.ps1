Function Get-BobResponse() {
    <#
    .SYNOPSIS
    Bob is a lackadaisical teenager. In conversation, his responses are very limited.
    
    .DESCRIPTION
    Bob is a lackadaisical teenager. In conversation, his responses are very limited.

    Bob answers 'Sure.' if you ask him a question.

    He answers 'Whoa, chill out!' if you yell at him.

    He answers 'Calm down, I know what I'm doing!' if you yell a question at him.

    He says 'Fine. Be that way!' if you address him without actually saying
    anything.

    He answers 'Whatever.' to anything else.
    
    .PARAMETER HeyBob
    The sentence you say to Bob.
    
    .EXAMPLE
    Get-BobResponse -HeyBob "Hi Bob"
    #>
    [CmdletBinding()]
    Param(
        [string]$HeyBob
    )

    $HeyBob = $HeyBob.Trim()
    $HeyBob = $HeyBob.Replace("`t", "")
    $HeyBob = $HeyBob.Replace(" ", "")

    if ($HeyBob -cmatch '^*[^\?]+$'){$return = "Whatever."}
    if ($HeyBob -cmatch '^[0-9A-Za-z;:(),.!\? ]+?\?$'){$return = "Sure."}
    if (($HeyBob -cmatch '^[^a-z]+?[!]?$') -and ($HeyBob -cmatch '[A-Z]+?')){$return = "Whoa, chill out!"}
    if (($HeyBob -cmatch '^[^a-z]+?\?$') -and ($HeyBob -cmatch '[A-Z]+?')){$return = "Calm down, I know what I'm doing!"}
    if ($HeyBob -match '^$'){$return = "Fine. Be that way!"}
    
    Return $return
}
