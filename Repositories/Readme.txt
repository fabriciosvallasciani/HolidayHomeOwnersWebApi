
// On package manager console -> Default Project -> Repositories






// Command to create users
Add-Migration -StartupProject HolidayHomesOwnersWebApi -Context "UsersContext" InitialUsers

// Admin user data
admin@admin.com
12345!

// Command to create owners, homes and images
Add-Migration -StartupProject HolidayHomesOwnersWebApi -Context "HolidayHomesOwnersContext" InitialHomesOwners