## Example app that makes use of SignalR Client Results

Requires Preview4 or later SDK/Runtime.
Can be installed from https://github.com/dotnet/installer/ under the Release/7.0.1xx-preview4 column of the table shown near the bottom of the page.

### Usage

F5 (ctrl-F5) to launch the server and get the URL for the app endpoint.

#### Using client results in a Hub method

1. Browse to the site with your favorite browser and it will connect with the SignalR Javascript client.
2. Open multiple tabs for multiple client connections
3. Grab an ID from the connected connections and paste it in the ID text box
4. Press 'Get Message' to invoke a Hub method which will ask the specified ID for a result
5. Go to the browser tab for the chosen ID and write a message in the Message text box
6. Press 'Send Message' to return the message to the server which will return it to the original client that asked for a result

#### Using client results from anywhere with `IHubContext`

1. Browse to the site with your favorite browser and it will connect with the SignalR Javascript client.
2. Copy the ID for a connected connection
3. Navigate to `/get/<ID>` in a new tab. Replace `<ID>` with the copied connection ID
5. Go to the browser tab for the chosen ID and write a message in the Message text box
6. Press 'Send Message' to return the message to the server which will return it to the `/get/<ID>` request
