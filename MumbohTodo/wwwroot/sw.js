const cacheName = 'cache-V1';
const dynamicCache = 'dyn-cache-V1';
let urlsToCache = [
    '/ ',
    '/css/site.css'
];

self.addEventListener('install', function (event) {
    //    // Perform install steps
    console.info('Service Worker Installed....');

    event.waitUntil(
        caches.open(cacheName)
            .then(function (cache) {
                console.log('Opened cache');
                return cache.addAll(urlsToCache);
            })
    );
    console.info('Caching Started...');

});

self.addEventListener('fetch', function (event) {
    event.respondWith(
        caches.match(event.request)
            .then(function (response) {
                // Cache hit - return response
                if (response) {
                    return response;
                }
                const netResponse = fetch(event.request);
                caches.open(dynamicCache).then((cache) => {
                    cache.add(event.request);
                });
                return netResponse;
            }
            )
    );
});