var url = 'http://telerikacademy.com/Courses/Courses/Details/239';

var output = parseURL(url);

console.log(output);

function parseURL(url) {
	var protocolEndIndex,
		serverEndIndex,
		protocol,
		server,
		resource,
		output = {};

	protocolEndIndex = url.indexOf('://');
	protocol = url.substring(0, protocolEndIndex);
	serverEndIndex = url.indexOf('/', protocolEndIndex + 3);
	server = url.substring(protocolEndIndex + 3, serverEndIndex);
	resource = url.substring(serverEndIndex);

	output['protocol'] = protocol;
	output['server'] = server;
	output['resource'] = resource;

	return output;
}