string password = Console.ReadLine();

// Store validation results to avoid recalculating
bool isLengthValid = CheckPassContainsBetweenSixAndTenCharacters(password);
bool isContentValid = CheckPassConsistOnlyOfLettersAndDigits(password);
bool hasEnoughDigits = CheckPassHaveAtLeastTwoDigits(password);

// Check if the password is valid
if (isLengthValid && isContentValid && hasEnoughDigits)
{
    Console.WriteLine("Password is valid");
}

// Print specific error messages
if (!isLengthValid)
{
    Console.WriteLine("Password must be between 6 and 10 characters");
}

if (!isContentValid)
{
    Console.WriteLine("Password must consist only of letters and digits");
}

if (!hasEnoughDigits)
{
    Console.WriteLine("Password must have at least 2 digits");
}

// Methods

static bool CheckPassContainsBetweenSixAndTenCharacters(string pass)
{
    return pass.Length >= 6 && pass.Length <= 10;
}

static bool CheckPassConsistOnlyOfLettersAndDigits(string pass)
{
    foreach (char currentChar in pass)
    {
        if (!char.IsLetterOrDigit(currentChar))
        {
            return false;
        }
    }
    return true;
}

static bool CheckPassHaveAtLeastTwoDigits(string pass)
{
    int digitCount = 0;

    foreach (char currentChar in pass)
    {
        if (char.IsDigit(currentChar))
        {
            digitCount++;
        }

        // Return true early if we have enough digits
        if (digitCount >= 2)
        {
            return true;
        }
    }

    return false;
}
