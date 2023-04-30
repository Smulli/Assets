<template>
    <div class="header">
        <header>
            <img :src="requiere(`@/assets/${fileLogo}`)" alt="Mira Softworks" widht="850" height="478"/>
        </header>
    </div>
</template>

<script>
export default {
    name:'Header',
    props: {
        fileLogo: String
    }
}
</script>