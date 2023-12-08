param(
    [Parameter(Mandatory = $true)]
    [string]$commandPath,
    [Parameter(Mandatory = $true)]
    [string]$filePath
)

function ExecuteCommand
{
    param (
        [Parameter(Mandatory = $true)]
        [string]$commandPath,
        [Parameter(Mandatory = $true)]
        [string]$parameter
    )
    dotnet run --project $commandPath $parameter
}

if (Test-Path $filePath)
{
    $lines = Get-Content $filePath
    foreach ($line in $lines)
    {
        if ($line -eq $null -or $line -eq "")
        {
            ExecuteCommand $commandPath " " 
            continue
        }
        ExecuteCommand $commandPath $line
    }
}
else
{
    Write-Output "File not found: $filePath"
}