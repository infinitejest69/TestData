using API.Helper;

var helper = new APIHelper();
var branches = await helper.GetAllbranches();
foreach (var branch in branches.Results)
{
    Console.WriteLine($"Branch To Delete {branch.Name}");
    await helper.DeleteBranchIfExists(branch.Name);
}