# UWP CollectionViewSource in DataTemplate in ResourceDictionary bug reproduction.

See broken and workaround tags for changes.

  - Take a CollectionViewSource in a DataTemplate in a ResourceDictionary
  - Use that DataTemplate in a page
  - Navigate to another instance of the same or another page also using the DataTemplate
  - The CollectionViewSource remains bound to the first page's collection
  - Navigating to other intermediate pages doesn't affect the result.