import CardOverlay from "../components/CardOverlay";

export default function ProjectCardContent({ title, contentData }) {
    return <div className="container d-flex justify-content-center align-items-center h-100 pt-5">
        <div className="col">
            <h1 className="mb-3 pt-5">- {title} -</h1>
            {
                contentData.map(contentSet => (
                    <div className="my-3" key={contentSet.id}>
                        <CardOverlay image={contentSet.image} title={contentSet.title} content={contentSet.content} date={contentSet.date} urlText={contentSet.urlText} url={contentSet.url} />
                    </div>
                ))
            }
        </div>
    </div>
}