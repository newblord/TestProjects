var React = require('react');
var ReactDOM = require('react-dom');

var VSTS = require('vso-node-api');

var collectionUrl = "https://hiteshkpatel.visualstudio.com"
var token = "fm4lfs62fa5rzncx7ugqov7tyvhimwptpumkguyvbdffffk2zw7q"

var auth = VSTS.getHandlerFromToken(token.toString("base64"));
var connect = new VSTS.WebApi(collectionUrl, auth);

connect.connect().catch(
    (reason) =>
    {
        console.log(reason);
    }
)

class Test extends React.Component {
    constructor(props)
    {
        super(props);
        this.state = {
            projects: []
        };
    }

    async loadProjects(e) {
        connect.getCoreApi().getProjects().then((data) => {
            this.setState( {projects: data });
        },
        (reason) => {
            console.log(reason);
        });
    }

    render() {
        return (
            <div>
                <div>
                    {
                        this.state.projects.map(project => 
                            <h1 key={project.name}>{project.name}</h1>
                        )
                    }
                </div>
                <div>
                    <input type="button" value="Load Projects" onClick={this.loadProjects.bind(this)}/>
                </div>
            </div>
        );
    }
}

ReactDOM.render(
    <Test />,
    document.getElementById('main')
);