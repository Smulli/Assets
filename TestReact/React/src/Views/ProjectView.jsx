import Data from "../Assets/Data/data.json";
import DeprecatedCardContent from "../layouts/DeprecatedCardContent";
import ProjectCardContent from "../layouts/ProjectCardContent";
import { Helmet } from "react-helmet";

const projectSet = Data.data[0].projectData;
const deprecatedSet = Data.data[0].deprecatedData

function ProjectView() {
    return <div>
        <Helmet>
            <title>Projects</title>

            <meta name="description" content="colorblind games" />
        </Helmet>

        <ProjectCardContent title="In Working" contentData={projectSet} />
        <DeprecatedCardContent title="Deprecated Projects" contentData={deprecatedSet} />
    </div>
}

export default ProjectView;