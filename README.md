# Send-List-With-TempData

## Beggin

### For send list to view with TempData

#### First you need a class like this

```
public class User
{
    public string Name { get; set; }
    public string Family { get; set; }
}
```
## Then initialize the class
```
//List for send with tempData
var user = new List<User>()
{
    new User(){Name = "Ali", Family = "Abbasi"},
    new User(){Name = "Mohammad", Family = "Abbasi"},
    new User(){Name = "Jhon", Family = "Abbasi"},
    new User(){Name = "Danny", Family = "Abbasi"},
    new User(){Name = "Mary", Family = "Abbasi"},
    new User(){Name = "Hossien", Family = "Abbasi"}
};
```
## Required reference
### Add package Microsoft.AspNetCore.MVC.NewtonsoftJson
```
using Newtonsoft.Json;
```

## Use JsonConvert class to create TempData
```
TempData["user"] = JsonConvert.SerializeObject(user);
```

## Next Use Newtonsoft.Josn to convert json string to list in view

```
using Newtonsoft.Json;

var tempdata = TempData["user"] as string; //Get tempData
var data = JsonConvert.DeserializeObject<List<User>>(tempdata); //Convert TempData to List
```

## And for end use it in view
```
<!--Show Data-->
<table class="table table-bordered">
    <thead>
        <tr>
            <th>Name</th>
            <th>Family</th>
        </tr>
    </thead>
    <tbody>
        @{ 
            foreach (var item in data)
            {
                <tr>
                    <td>@item.Name</td>
                    <td>@item.Family</td>
                </tr>
            }
        }
    </tbody>
    <tfoot>
        <tr>
            <th>Name</th>
            <th>Family</th>
        </tr>
    </tfoot>
</table>
```
## Please Read License
